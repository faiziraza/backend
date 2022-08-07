using Dal_2.Repository.Iservice;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudOperation.Controllers
{
    public class AreaController : Controller
    {
        private readonly IArea _area;
        public AreaController(IArea area)
        {
            _area = area;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetCountry()
        {
         var result=   _area.GetCountry();
            return Json ( result);
        }
             
    }
}
