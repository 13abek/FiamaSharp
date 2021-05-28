using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Fiama.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ShoppingRepositories;

namespace Fiama.Controllers
{
    public class CartController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IBasketRepository _basketRepository;
        

        public CartController(IMapper mapper,
                              IBasketRepository basketRepository)
        {
            _mapper = mapper;
            _basketRepository = basketRepository;

        }
        public IActionResult Index()
        {
            ViewBag.Pages = "Cart";
            return View();
        }

        public IActionResult Remove(int id)
        {

            var basket = _basketRepository.GetBasketById(id);    //id gore token tapilir yoxdusa token notfound

            if (basket == null) return NotFound();

            Request.Cookies.TryGetValue("token", out string token); //tapilan tokenin bazadaki token ile eynili yoxlanilir 
          
            if (basket.Token != token) return NotFound();   //,ferqlidirse notfound

            _basketRepository.RemoweBasket(basket);

            var basketItems = _basketRepository.GetBasketByToken(token);
            var basketModel = _mapper.Map<IEnumerable<Basket>, IEnumerable<BasketViewModel>>(basketItems);


            return PartialView("Basket/_NavbarBasket", basketModel);   

            //var total = 0M;                                         bunun evezine partialView gelir?
            //foreach (var item in basketModel)
            //{
            //    var price = item.Product.Price;

            //    if (item.Product.Discount != null)
            //    {
            //        price= item.Product.Price - (item.Product.Price * item.Product.Discount.Percentage) / 100;   
            //    }

            //    total += (price * item.Count);


            //}

            //return Ok(new
            //     {
            //    count = basketItems.Count(),
            //   total= total.ToString("#.00")
            //           }
            //         );
        }


        public IActionResult Add(int id)
        {
            //Basket mehsul varsa sayini artirmaliyiq ,yoxdursa elave etmeliyik.

            Request.Cookies.TryGetValue("token", out string token);

            var basketItem = _basketRepository.GetBasketByProductAndToken(id, token);

            if (basketItem==null)
            {
                Basket basket = new Basket
                {
                    ProductId = id,
                    Token = token,
                    Count = 1,
                    ModifiedBy = "System",
                    AddedBy = "System"
                };
                _basketRepository.CreateBasket(basket);
            }
            else
            {
                _basketRepository.ChangeCount(basketItem, basketItem.Count+1);

            }
            var basketItems = _basketRepository.GetBasketByToken(token);   //Melumat bazasindan tapiriq ve umumi tokene gore basketin icindeki items cekirik 
            var basketModel = _mapper.Map<IEnumerable<Basket>, IEnumerable<BasketViewModel>>(basketItems); //Burada Modelleshdiririk


            return PartialView("Basket/_NavbarBasket", basketModel); //Burda ise View gonderirik "basketModel" orreturn PartialView("Basket/_NavbarBasket", basketModel); //Burda ise View gonderirik ordanda Html gonnderirik ki ajax vasitesi ile js goturub headerse yapishdirir. 
        }
    }
}