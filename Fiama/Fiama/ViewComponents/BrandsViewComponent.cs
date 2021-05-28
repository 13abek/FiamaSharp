using AutoMapper;
using Fiama.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContentRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiama.ViewComponents
{
    public class BrandsViewComponent:ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;

        public BrandsViewComponent(IMapper mapper,
                                    IContentRepository contentRepository)
        {
            _mapper = mapper;
            _contentRepository = contentRepository;
        }

        public IViewComponentResult Invoke()
        {
            var brands = _contentRepository.GetBrands();

            var model = _mapper.Map<IEnumerable<Brand>, IEnumerable<BrandViewModel>>(brands);

            return View(model);
        }

    }
}
