using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Repository.Repositories.ShoppingRepositories;
using Repository.Models;
using Fiama.Models;

namespace Fiama.ViewComponents
{
    public class TopProductViewComponent:ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public TopProductViewComponent(IMapper mapper,
                                       IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public IViewComponentResult Invoke()
        {
            var products = _productRepository.GetTopSellingProducts(4);  

            var model=_mapper.Map<IEnumerable<Product>,IEnumerable<ProductViewModel>> (products);

            return View(model);
        }
      

    }
}
