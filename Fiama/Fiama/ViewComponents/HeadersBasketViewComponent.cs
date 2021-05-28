using AutoMapper;
using Fiama.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ShoppingRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiama.ViewComponents
{
    public class HeadersBasketViewComponent:ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IBasketRepository _basketRepository;

        public HeadersBasketViewComponent(IMapper mapper ,
                                       IBasketRepository basketRepository)
        {
            _mapper = mapper;
            _basketRepository = basketRepository;
        }


        public IViewComponentResult Invoke()
        {
            Request.Cookies.TryGetValue("token", out string token);

            var basketItems = _basketRepository.GetBasketByToken(token);

            var model = _mapper.Map<IEnumerable<Basket>, IEnumerable<BasketViewModel>>(basketItems);

            return View(model);
        }

    }
}
