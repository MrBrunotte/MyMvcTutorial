using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Indexpage = "This is the index page";
            return View();
        }

        public IActionResult MyUser(string userName, int age=48)
        {
            ViewBag.User = userName;
            ViewBag.Age = age;
                return View();
        }
    }
}
