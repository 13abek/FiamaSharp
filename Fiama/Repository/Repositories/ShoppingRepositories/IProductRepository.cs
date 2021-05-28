using Repository.Enums;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.ShoppingRepositories
{
  public  interface  IProductRepository
    {
        IEnumerable<Product> GetTopSellingProducts (int limit);
        IEnumerable<Product> GetNewArrivalProducts (int limit);
        IEnumerable<Product> GetOffSalesProducts(int limits);
        IEnumerable<Product> GetProductByCategoryId(int CategoryId, int take, int skip, ProductListing Orderby);
        int GetProductsCountByCategoryId(int categoryId);
        Product GetProductById(int id);
        Product GetProductDetailsById(int id);

        void AddProductReview(ProductReview review);
        //void CalcStarAverage(int productId);

    }
}
