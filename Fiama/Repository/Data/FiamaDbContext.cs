using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Repository.Models;
namespace Repository.Data
{
   public class FiamaDbContext:DbContext
    {
        public FiamaDbContext(DbContextOptions<FiamaDbContext> options) : base(options)
        {

        }
        public DbSet<Brand>Brands  { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Discount> Discounts  { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Label> Labels  { get; set; }
        public DbSet<Product> Products  { get; set; }
        public DbSet<ProductImage>ProductImages  { get; set; }
        public DbSet<ProductOption> ProductOptions  { get; set; }
        public DbSet<ProductOptionItem> ProductOptionItems  { get; set; }
        public DbSet<ProductReview> Reviews { get; set; }
        public DbSet<ProductToDiscount> ProductToDiscounts { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<ShopCollection>  ShopCollections { get; set; }
        public DbSet<SliderItem> SliderItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Basket> Baskets { get; set; }


    }
}
