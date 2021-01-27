using Microsoft.AspNetCore.Mvc;
using RegisterLoginPart1.Models;
using RegisterLoginPart1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterLoginPart1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogin(UserModel userModel)
        {
            // create an instance of the SecurityServices in the folder Services
            SecurityServices securityService = new SecurityServices();

            if (securityService.IsValid(userModel))
            {
                return View("LoginSuccess", userModel);
            }
            else
            {
                return View("LoginFailure", userModel);
            }
        }
    }
}


