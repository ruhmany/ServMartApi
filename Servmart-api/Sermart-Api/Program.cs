using Application_Layer.Interfaces;
using Application_Layer.Repos;
using Application_Layer.Services;
using ApplicationLayer.IRepos;
using Domain_Layer.Models;
using Infrastructure_Layer.IRepos;
using InfrastructureLayer;
using InfrastructureLayer.Interfaces;
using InfrastructureLayer.Repos;
using InfrastructureLayer.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Sermart_Api.Helpers;
using Sermart_Api.Mapper;
using System.Text;
using System.Text.Json.Serialization;

namespace Sermart_Api
{
	public class Program
	{
		public static void Main( string[] args )
		{
			var builder = WebApplication.CreateBuilder( args );
			builder.Services.AddControllers().AddJsonOptions( x =>
				x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles );
			// Add services to the container.
			builder.Services.Configure<JWT>( builder.Configuration.GetSection( "JWT" ) );
			builder.Services.Configure<CloudinraySettings>( builder.Configuration.GetSection( "CloudinarySettings" ) );
			builder.Services.AddScoped( typeof( IBaseRepo<> ), typeof( BaseRepos<> ) );
			builder.Services.AddScoped<IUserRepo, UserRepo>();
			builder.Services.AddScoped<IAuthService, AuthService>();
			builder.Services.AddScoped<IPhotoService, PhotoService>();
			builder.Services.AddScoped<IVideoService, VideoService>();
			builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
			builder.Services.AddScoped<IProduct, Products>();
			builder.Services.AddScoped<IProductCatgory, ProductCatgoryRepo>();
			builder.Services.AddScoped<IAddressRepo, AddressRepo>();
			builder.Services.AddScoped<IRequestServiceCategory, RequestServiceCategory>();


			builder.Services.AddAutoMapper( p => p.AddProfile( new productProfile() ) );
			builder.Services.AddAutoMapper( p => p.AddProfile( new CatgoryProfile() ) );
			builder.Services.AddScoped<IRequestRepo, RequsestRepo>();
			builder.Services.AddScoped<IAuthRepo, AuthRepo>();
			builder.Services.AddScoped<IRequestOfferRepo, RequestOfferRepo>();
			builder.Services.AddScoped<IServiceRepo, ServiceRepo>();
			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();
			builder.Services.AddDbContext<AppDbContext>( options =>
			{
				options.UseLazyLoadingProxies().UseSqlServer( builder.Configuration.GetConnectionString( "DefaultConnection" ),
					m => m.MigrationsAssembly( typeof( AppDbContext ).Assembly.FullName ) );
			} );
			builder.Services.AddIdentity<User, IdentityRole>( options =>
			{
				options.Password.RequireDigit = true;
				options.Password.RequireLowercase = true;
				options.Password.RequireUppercase = true;
				options.Password.RequiredLength = 8;
			} )
			.AddEntityFrameworkStores<AppDbContext>()
			.AddDefaultTokenProviders();
			builder.Services.AddCors();

			builder.Services.AddAuthentication( options =>
			{
				options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

			} ).AddJwtBearer( o =>
			{
				o.RequireHttpsMetadata = false;
				o.SaveToken = false;
				o.TokenValidationParameters = new TokenValidationParameters
				{
					ValidateIssuerSigningKey = true,
					ValidateIssuer = true,
					ValidateAudience = true,
					ValidateLifetime = true,
					ValidIssuer = builder.Configuration[ "JWT:Issuer" ],
					ValidAudience = builder.Configuration[ "JWT:Audience" ],
					IssuerSigningKey = new SymmetricSecurityKey( Encoding.UTF8.GetBytes( builder.Configuration[ "JWT:Key" ] ) )
				};
			} );

			builder.Services.Configure<FormOptions>( Option =>
			{
				Option.ValueLengthLimit = int.MaxValue;
				Option.MultipartBodyLengthLimit = int.MaxValue;
				Option.MemoryBufferThreshold = int.MaxValue;

			} );


			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if ( app.Environment.IsDevelopment() )
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthentication();
			app.UseAuthorization();

            builder.Services.AddCors(option =>
            {
                option.AddDefaultPolicy(i => {
                    i.AllowAnyOrigin();
                    i.AllowAnyMethod();
                    i.AllowAnyHeader();
                });
            });
            app.MapControllers();

			app.Run();
		}
	}
}