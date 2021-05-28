using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Fiama.Libs.AuthFilter;
using Fiama.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.AuthRepositories;
using Repository.Repositories.ShoppingRepositories;

namespace Fiama.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAuth _auth;
        private readonly IProductRepository _productRepository;

        public ProductsController(IMapper mapper,
                                  IAuth auth,
                                  IProductRepository productRepository)
        {
            _mapper = mapper;
            _auth = auth;
            _productRepository = productRepository;
        }

        public IActionResult Index(int id)
        {
            ViewBag.Pages = "Product";

            var product = _productRepository.GetProductDetailsById(id);
            if (product == null) return NotFound();

            var model = _mapper.Map<Product, ProductViewModel>(product);

          var RelatedProduct=  _productRepository.GetProductByCategoryId(product.CategoryId, 10, 0,Repository.Enums.ProductListing.Newness);

            ViewBag.RelatedProduct = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(RelatedProduct);
            return View(model);
        }
        public IActionResult AddReview(int id)
        {
            if (_auth.user == null) return NotFound();
            var product = _productRepository.GetProductById(id);
            if (product == null) return NotFound();
            ViewBag.ProductId = product.id;
            ViewBag.ProductName = product.Name;


            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddReview(AddReviewViewModel model)
        {
            if (_auth.user == null) return NotFound();
            if (ModelState.IsValid)
            {
                ProductReview productReview = new ProductReview
                {
                    Status=false,
                    ProductId = model.ProductId,
                    UserId = _auth.user.id,
                    Content = model.Content,
                    AddedBy = _auth.user.Firstname+" "+_auth.user.Lastname,
                    ModifiedBy = _auth.user.Firstname + " " + _auth.user.Lastname,
                    AddedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
            };

                _productRepository.AddProductReview(productReview);

            }

            var product = _productRepository.GetProductById(model.ProductId);
            if (product == null) return NotFound();
            ViewBag.ProductId = product.id;
            ViewBag.ProductName = product.Name;
            return Ok(model);
        }

    }
}