using Microsoft.AspNetCore.Http;
using Repository.Models;
using Repository.Repositories.AuthRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiama.Libs.AuthFilter
{
    public class Auth:IAuth
    {
        private readonly IAuthRepository _authRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public Auth(IAuthRepository authRepository,
                    IHttpContextAccessor httpContextAccessor)
        {
            _authRepository = authRepository;
            _httpContextAccessor = httpContextAccessor;
        }

        public User user
        {
            get
            {
                _httpContextAccessor.HttpContext.Request.Cookies.TryGetValue("token", out string token);

            return  _authRepository.CheckByToken(token);

            }
        }
    }
}
