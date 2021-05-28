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
    public class CategoriesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly  ICategoryRepository _categoryRepository;
        private readonly IProductRepository _productRepository;

        public CategoriesController(IMapper mapper,
                                     ICategoryRepository categoryRepository,
                                    IProductRepository productRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
        }
        public IActionResult Index(CategorySearchViewModel categorySearch)
        {
            var category = _categoryRepository.GetCategoryById(categorySearch.id);
            var products = _productRepository.GetProductByCategoryId(category.id,
                                                                     categorySearch.Limit,
                                                                     (categorySearch.Page-1)*categorySearch.Limit   ,
                                                                     Repository.Enums.ProductListing.Newness);
            var producCount = _productRepository.GetProductsCountByCategoryId(category.id);
            if (category == null) return NotFound();

           
            var model = new CategoryListViewModel
            {
                Category = _mapper.Map<Category, CategoryViewModel>(category),
                Products = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(products),
                Count=producCount,
                Page=categorySearch.Page,
                Limit=categorySearch.Limit
            };

            return View(model);
        }
    }
}