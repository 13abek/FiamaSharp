using System;
using System.Collections.Generic;
using System.Text;
using Repository.Models;

namespace Repository.Repositories.AuthRepositories
{
    public interface IAuthRepository
    {
        User Register(User user);
        User Login(string email, string password);
        bool UserExsist(string email);
        User CheckByToken(string token);
        void UpdateToken(int id, string token);
        bool CheckEmail(string email);
        User GetUserByEmailAndToken(string email, string token);
    }
}
