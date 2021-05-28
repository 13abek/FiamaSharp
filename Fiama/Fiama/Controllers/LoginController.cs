using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Fiama.Models.Account;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.AuthRepositories;
using Repository.Repositories.ShoppingRepositories;

namespace Fiama.Controllers
{
    public class LoginController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAuthRepository _authRepository;
        private readonly IBasketRepository _basketRepository;

        public LoginController(IMapper mapper,
                                IAuthRepository authRepository,
                                IBasketRepository basketRepository)
        {
            _mapper = mapper;
            _authRepository = authRepository;
            _basketRepository = basketRepository;
        }

        public IActionResult Index()
        {
            ViewBag.Pages = "Login";
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LogIn(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                var user = _authRepository.Login(login.Email, login.Password);
                if (user!=null)
                {

                    user.Token = Guid.NewGuid().ToString();  //user logIn edendede onun yeni token veririk 
                        
                    _authRepository.UpdateToken(user.id, user.Token); //Burda ise userin kohne tokeni ile yenisini evez edirik

                    Response.Cookies.Delete("token"); //Bu yol ile kohne tokeni silirik 

                    Response.Cookies.Append("token", user.Token, new Microsoft.AspNetCore.Http.CookieOptions      //yaratdigimiz tokeni burda sett edirik ve sontarix veririk
                    {
                        HttpOnly = true,
                        Expires = DateTime.Now.AddYears(1) 
                    });

                    Request.Cookies.TryGetValue("token", out string token);  //Burda tokenin tapib velue-sini gotururuk  

                    _basketRepository.UpdateBasketsToken(token, user.Token); //Burda ise basket table-indaki user-in tokenin yeni yaratdigimiz token ile evez edirik


                    return RedirectToAction("index", "account"); //ve sonda redirect edirik account page -ine

                }

                ModelState.AddModelError("Login.Password", "e-mail or password is incorrect");
            }


            return View("~/Views/Login/Index.cshtml", new AccountViewModel {
                Login = login
            });
        }
        public IActionResult LogOut()
        {
            Request.Cookies.TryGetValue("token", out string token); //Burada tokeni sett edirik Requesten

            User user = _authRepository.CheckByToken(token); //Hemin token vasitesi ile useri tapiriq.

                _authRepository.UpdateToken(user.id, null); //Burda ise userin tokenin null edirik.

            return RedirectToAction("index", "home");
        }
    }
}