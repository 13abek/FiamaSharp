﻿using AutoMapper;
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
    public class NewArrivalViewComponent:ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

      public  NewArrivalViewComponent(IMapper mapper,
                                IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

      public IViewComponentResult Invoke()
        {

            var products = _productRepository.GetNewArrivalProducts(4);

            var model = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(products);
            return View(model);
        }

    }
}
