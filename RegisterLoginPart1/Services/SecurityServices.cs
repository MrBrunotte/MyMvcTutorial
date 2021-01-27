using Microsoft.AspNetCore.Mvc;
using RegisterLoginPart1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterLoginPart1.Services
{
    public class SecurityServices : Controller
    {
        UsersDAO usersDAO = new UsersDAO();
        public SecurityServices()
        {
            
        }

        public bool IsValid(UserModel user)
        {
            return usersDAO.FindUserByNAmeAndPassword(user);
        }
    }
}
