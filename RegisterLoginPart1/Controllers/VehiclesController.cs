using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterLoginPart1.Controllers
{
    public class VehiclesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddCar(Models.CarInfoModel carInfoModel)
        {
            return View("AddCar");
        }
    }
}
