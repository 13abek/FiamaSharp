﻿using AutoMapper;
using Fiama.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContentRepositories;
using System.Collections.Generic;

namespace Fiama.ViewComponents
{
    public class SliderViewComponent:ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;
        public SliderViewComponent(IMapper mapper,
                                   IContentRepository contentRepository)
        {
            _mapper = mapper;
            _contentRepository = contentRepository;


        }

        public IViewComponentResult Invoke()
        {
            var sliderItems = _contentRepository.GetSliderItems();
            var model = _mapper.Map<IEnumerable<SliderItem>,IEnumerable<SliderItemViewModel>>(sliderItems);

            return View(model);
        }
    }
}
