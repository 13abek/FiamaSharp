using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ShoppingRepositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly FiamaDbContext _context;
        public CategoryRepository(FiamaDbContext context)
        {
            _context = context;
        }
        public Category GetCategoryById(int id)
        {
            return _context.Categories.Find(id);
        }
    }
}
