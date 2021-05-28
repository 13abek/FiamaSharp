using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{
    public class ContentRepository : IContentRepository
    {
        private readonly FiamaDbContext _context;

        public ContentRepository(FiamaDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Brand> GetBrands()
        {
            return _context.Brands.Where(b => b.Status)
                                  .OrderByDescending(b=>b.AddedDate)
                                  .ToList();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.Where(c => c.Status)
                                      .OrderBy(c=>c.AddedDate)
                                      .ToList();
        }

        public IEnumerable<ShopCollection> GetShopCollections()
        {
            return _context.ShopCollections.Where(sc => sc.Status)
                                           .OrderBy(sc => sc.OrderBy)
                                           .ToList();
        }

        public IEnumerable<SliderItem> GetSliderItems()
        {
            return _context.SliderItems.Where(s => s.Status)
                                        .OrderBy(s => s.OrderBy)
                                        .ToList();
        }
    }
}
