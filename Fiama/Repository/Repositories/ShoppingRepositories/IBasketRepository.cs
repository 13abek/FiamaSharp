using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.ShoppingRepositories
{
    public interface IBasketRepository
    {
        public IEnumerable<Basket> GetBasketByToken(string token);

        Basket CreateBasket(Basket basket);
        Basket GetBasketById(int id);
        void RemoweBasket(Basket basket);
        Basket GetBasketByProductAndToken(int productId, string token);
        void ChangeCount(Basket basketItem, int count);
        void UpdateBasketsToken(string GuestToken, string userToken);
    }
}
