﻿
using Domain_Layer.Models;
using Infrastructure_Layer.IRepos;
using InfrastructureLayer;
using Microsoft.EntityFrameworkCore;

namespace Application_Layer.Repos
{
	public class RequestServiceCategory : IRequestServiceCategory
	{
		private readonly AppDbContext _context;

		public RequestServiceCategory( AppDbContext context ) { _context = context; }

		public async Task AddCategory( ServiceCategory entity )
		{
			await _context.ServiceCategorie.AddAsync( entity );
		}

		public async Task<IEnumerable<ServiceCategory>> GetAllCategories()
		{
			return await _context.ServiceCategorie.ToListAsync();
		}

		public async Task<ServiceCategory> GetCategoryById( string id )
		{
			return await _context.ServiceCategorie.FirstOrDefaultAsync( x => x.ID.ToString() == id );
		}
	}
}
