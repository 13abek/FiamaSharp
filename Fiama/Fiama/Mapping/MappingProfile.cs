using AutoMapper;
using Fiama.Models;
using Fiama.Models.Account;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiama.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile() 
        {
            CreateMap<SliderItem, SliderItemViewModel>();
            CreateMap<ShopCollection,ShopCollectionViewModel>();
            CreateMap<Label, LabelViewModel>();
            CreateMap<Discount, DiscountViewModel>();
            CreateMap<Product, ProductViewModel>()
                  .ForMember(d => d.Images, opt => opt.MapFrom(src => src.Images.OrderBy(p => p.OrderBy).Select(p => p.Name)))
                  .ForMember(d => d.Discount, opt => opt.MapFrom(src => src.Discounts
                                                                         .Where(d => d.Discount.StartDate <= DateTime.Now && d.Discount.EndDate >= DateTime.Now)
                                                                         .OrderByDescending(d => d.Discount.AddedDate)
                                                                         .FirstOrDefault().Discount));
            CreateMap<Brand, BrandViewModel>();
            CreateMap<Basket, BasketViewModel>();
            CreateMap<RegisterViewModel, User>();
            CreateMap<Category, CategoryViewModel>();
            CreateMap<ProductReview, ReviewViewModel>();
            CreateMap<ProductOptionItem, OptionItemsViewModel>();
            CreateMap<ProductOption, OptionViewModel>();
            CreateMap<User, UserViewModel>();
            CreateMap<AddReviewViewModel, ProductReview>();
            
        }
    }
}
