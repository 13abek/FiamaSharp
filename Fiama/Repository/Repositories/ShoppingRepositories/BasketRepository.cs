using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Repository.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Repository.Repositories.ShoppingRepositories
{
    public class BasketRepository : IBasketRepository
    {
        private readonly FiamaDbContext _context;

        public BasketRepository(FiamaDbContext context)
        {
            _context = context;
        }

        public void ChangeCount(Basket basketItem, int count)
        {
            basketItem.Count = count;
            _context.SaveChanges();
        }

        public Basket CreateBasket(Basket basket)
        {
            basket.AddedDate = DateTime.Now;
            basket.ModifiedDate = DateTime.Now;

            _context.Baskets.Add(basket);
            _context.SaveChanges(); 

            return basket;
        }

        public Basket GetBasketById(int id)
        {
            return _context.Baskets.Find(id);
        }

        public Basket GetBasketByProductAndToken(int productId, string token)
        {
            return _context.Baskets.SingleOrDefault(b => b.ProductId == productId && b.Token == token);
        }

        public IEnumerable<Basket> GetBasketByToken(string token)
        {

            

            return _context.Baskets.Include("Product")
                                   .Include("Product.Images")
                                   .Include("Product.Discounts")
                                   .Include("Product.Discounts.Discount")
                                   .Where(b => b.Token == token)
                                   .ToList();
        }

        public void RemoweBasket(Basket basket)
        {
            _context.Baskets.Remove(basket);
            _context.SaveChanges();
        }

        public void UpdateBasketsToken(string GuestToken, string userToken)
        {
            foreach (var item in _context.Baskets.Where(b=>b.Token==GuestToken).ToList()) //burada register olmadan saytda dolashan guest userlere verilmish tokenleri register olduqdan sonra verilen token ile beraber edirik ki eger guestUserin basketi varsa register olduqdan sonra bazada hemin userin datalarina elave edilsin
            {
                item.Token = userToken;
            }
            _context.SaveChanges();
        }
    }
}
