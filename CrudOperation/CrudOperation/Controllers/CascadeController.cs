using Dal_2.Repository.Iservice;
using Microsoft.AspNetCore.Mvc;
using Runner.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudOperation.Controllers
{
    public class CascadeController : Controller
    {
        private readonly IuserData _iuserData;

        public CascadeController(IuserData iuserData)
        {
            _iuserData = iuserData;
        }
        public IActionResult Index()
        {
            return View();
        }
        //public JsonResult GetCountry()
        //{
        //    //var result = _Country.GetCountry
        //    //return new JsonResult(result);
        //}
        public ActionResult AddUser(UserView userView)
        {
          var resulut=  _iuserData.AddUser(userView);
            return View(resulut);

        }
        //public  ActionResult AddCountry()
        //{
        //    UserView userView = new UserView();
        //    userView.countries =
        //    return View();
        //}
    }
}
