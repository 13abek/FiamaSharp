using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Repository.Enums;

namespace Repository.Repositories.ShoppingRepositories
{
    public class ProductRepository:IProductRepository
    {
        private readonly FiamaDbContext _context;
        public ProductRepository(FiamaDbContext context)
        {
            _context = context;
        }

        public void AddProductReview(ProductReview review)
        {
          

            _context.Reviews.Add(review);
            _context.SaveChanges();
         
        }

        //public void CalcStarAverage(int productId)
        //{
        //    var product = this.GetProductById(productId);
        //    product.StarCount = _context.Reviews.Where(pr => pr.ProductId == productId).Average(pr => pr.star);  //Double cinsinden olduguna gore erro verir bazada starcount,star double cinsin kecirtmek lazimdi
        //}

        public IEnumerable<Product> GetNewArrivalProducts(int limit)
        {
            return _context.Products.Include("Images")
                                   .Include("Label")
                                   .Include("Discounts")
                                   .Include("Discounts.Discount")
                                   .Where(p => p.Status)
                                   .Where(p => p.IsNewArrival)
                                   .OrderByDescending(p => p.AddedDate)
                                   .Take(limit)
                                   .ToList();
        }

        public IEnumerable<Product> GetOffSalesProducts(int limits)
        {
            return _context.Products.Include("Images")
                                     .Include("Label")
                                     .Include("Discounts")
                                     .Include("Discounts.Discount")
                                     .Where(p => p.Status)
                                     .Where(p => p.IsOffSales)
                                     .OrderByDescending(p => p.AddedDate)
                                     .ToList();
        }

        public IEnumerable<Product> GetProductByCategoryId(int CategoryId, int take, int skip, ProductListing Orderby)
        {
            var products= _context.Products.Include("Images")
                                     .Include("Label")
                                     .Include("Discounts")
                                     .Include("Discounts.Discount")
                                     .Where(p => p.CategoryId == CategoryId)
                                     .Where(p => p.Status);
            switch (Orderby)
            {
                case ProductListing.Newness:
                    products.OrderByDescending(p => p.AddedDate);
                    break;
                case ProductListing.ProductAsc:
                    products.OrderBy(p => p.Price);
                    break;
                case ProductListing.ProductDesc:
                    products.OrderByDescending(p => p.Price);
                    break;
            };
            
          return  products.Skip(skip).Take(take).ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products
                           .FirstOrDefault(p=>p.Status &&  p.id == id);
        }

        public Product GetProductDetailsById(int id)
        {
            return _context.Products
                               .Include("Label")
                               .Include("Discounts")
                               .Include("Discounts.Discount")
                               .Include("Images")
                               .Include("Reviews")
                               .Include("Reviews.User")
                               .Include("Category")
                               .Include("Options")
                               .Include("Options.OptionItems")
                               .FirstOrDefault(p => p.Status && p.id == id);
        }

        public int GetProductsCountByCategoryId(int categoryId)
        {
            return _context.Products.Where(p => p.CategoryId == categoryId)   //pages count logic
                                    .Where(p => p.Status)
                                    .Count();
        }

        public IEnumerable<Product> GetTopSellingProducts(int limit)
        {
            return _context.Products.Include("Images")
                                    .Include("Label")
                                    .Include("Discounts")
                                    .Include("Discounts.Discount")
                                    .Where(p => p.Status)
                                    .Where(p => p.IsTopProduct)
                                    .OrderByDescending(p => p.AddedDate)
                                    .Take(limit)
                                    .ToList();

        }

    }
}
