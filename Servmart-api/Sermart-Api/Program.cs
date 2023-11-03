using Application_Layer;
using Application_Layer.Repos;
using Domain_Layer.Models;
using Infrastructure_Layer.IRepos;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sermart_Api.Helpers;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Application_Layer.Interfaces;
using Application_Layer.Services;
using AutoMapper;
using Sermart_Api.Mapper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.AspNetCore.Http.Features;
using System.Reflection.PortableExecutable;

namespace Sermart_Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.Configure<JWT>(builder.Configuration.GetSection("JWT"));
            builder.Services.Configure<CloudinraySettings>(builder.Configuration.GetSection("CloudinarySettings"));
            builder.Services.AddScoped(typeof(IBaseRepo<>), typeof(BaseRepos<>));
            builder.Services.AddScoped<IUserRepo, UserRepo>();
            builder.Services.AddScoped<IAuthService, AuthService>();
            builder.Services.AddScoped<IPhotoService, PhotoService>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<IProduct, Products>();
            builder.Services.AddScoped<IProductCatgory, ProductCatgoryRepo>();


            builder.Services.AddAutoMapper(p=>p.AddProfile(new productProfile()));
            builder.Services.AddAutoMapper(p=>p.AddProfile(new CatgoryProfile()));
            builder.Services.AddScoped<IRequestRepo, RequsestRepo>();
            builder.Services.AddScoped<IAuthRepo, AuthRepo>();
            builder.Services.AddScoped<IRequestOfferRepo, RequestOfferRepo>();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString( "DefaultConnection" ),
                    m => m.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName));                
            });
            builder.Services.AddIdentity<User, IdentityRole>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 8;
            })
            .AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders();
            builder.Services.AddCors();

            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(o =>
            {
                o.RequireHttpsMetadata = false;
                o.SaveToken = false;
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidIssuer = builder.Configuration["JWT:Issuer"],
                    ValidAudience = builder.Configuration["JWT:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Key"]))
                };
            });

            builder.Services.Configure<FormOptions>(Option =>
            {
                Option.ValueLengthLimit = int.MaxValue;
                Option.MultipartBodyLengthLimit = int.MaxValue;
                Option.MemoryBufferThreshold = int.MaxValue;

            });


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(builder.Environment.ContentRootPath, "Images")
                    )
                    ,RequestPath = "/Images"
            });

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseCors(o =>
            {
                o.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
            });
            app.MapControllers();

            app.Run();
        }
    }
}