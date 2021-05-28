using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Fiama.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Data;
using Repository.Models;
using Repository.Repositories.ShoppingRepositories;

namespace Fiama.Controllers
{
    public class AboutController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IBasketRepository _basketRepository;
        private readonly FiamaDbContext _context;

        public AboutController(IMapper mapper, IBasketRepository basketRepository, FiamaDbContext context)
        {
            _mapper = mapper;
            _basketRepository =basketRepository;
            _context = context;
            
        }
        public IActionResult Index()
        {
            ViewBag.Pages = "About";

            return View();
        }
        public IActionResult Test()
        {
            Request.Cookies.TryGetValue("token", out string token);
            var BasketItem = _basketRepository.GetBasketByToken(token);

            var model = _mapper.Map<IEnumerable<Basket>, IEnumerable<BasketViewModel>>(BasketItem);

          


            return Ok(model);
        }
    }
}