using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Fiama.Models.Account;
using Microsoft.AspNetCore.Mvc;
using Repository.Data;
using Repository.Models;
using Repository.Repositories.AuthRepositories;
using Repository.Repositories.ShoppingRepositories;

namespace Fiama.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IMapper _mappper;
        private readonly IAuthRepository _authRepository;
        private readonly IBasketRepository _basketRepository;

        public RegisterController(IMapper mapper,
                                  IAuthRepository authRepository,
                                  IBasketRepository basketRepository)
        {
            _mappper = mapper;
            _authRepository = authRepository;
            _basketRepository = basketRepository;
        }
        public IActionResult Index()
        {
            ViewBag.Pages = "Register";
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RegisterViewModel register)
        {
            bool CheckUserEmail = _authRepository.CheckEmail(register.Email); //burada emil yoxlanilmaidir ki hemin e-mail bazada varmi

            if(CheckUserEmail)
            {
                ModelState.AddModelError("Email", "This E-mail already exists");  //,eger varsa  model error gonderirik 
            }
            if (ModelState.IsValid)  //Model is valid -dirse validata problemi yoxdursa
            {
                var user = _mappper.Map<RegisterViewModel, User>(register); // Mapping yolu ile  regisViewmodel den datani user modele otururuk
                user.Token = Guid.NewGuid().ToString();     // yeni token yaradiriq qoyuruq    
                user.Status = true;
                _authRepository.Register(user);     //burda ise register methodu ile ise create edib db yaziriq yaradiriq;



                Response.Cookies.Delete("token"); //Bu kod ile computerin yaddashinda qalmish kohne token silirik

                Response.Cookies.Append("token",user.Token, new Microsoft.AspNetCore.Http.CookieOptions //--yaratdigimiz Token set olunur //Burada verilmish yeni tokene muddet ve httponly feature sini veririk  ( yaradilmish//Burada usere Create ederken yeni token yaradiriq
                {
                    HttpOnly = true,
                    Expires = DateTime.Now.AddYears(1)
                });

                Request.Cookies.TryGetValue("token", out string token);//bunun ile kohne token tapilir 

                _basketRepository.UpdateBasketsToken(token, user.Token);  //Burada -user- register elemedikden once yaratdiqlari basketleri -token yoli ile yeni token ile beraber edib bazada eynileshdirme prorsesi edirik.(basket varsa onu update edib register olan userin datasina elave etmeliyik

                return RedirectToAction("index", "account");

            }




            return View("~/Views/Register/Index.cshtml", new AccountViewModel      //Burada ise Register View gonderdiyimiz AccountViewModel cinsinden data  yenisi ile evez edirik
            {
                Register = register
            });
            
        }

    }
} 