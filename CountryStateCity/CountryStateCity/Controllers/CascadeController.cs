using CountryStateCity.Models;
using CountryStateCity.ModelView;
using DAL.Repository.IService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryStateCity.Controllers
{
    public class CascadeController : Controller
    {
        public readonly ICountry _country;
        public CascadeController(ICountry country)
        {
            _country = country;
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult GetCountry()
        {
          //  UserViews userViews = new UserViews();
          //  userViews.countries = applicationDbContext.countries.ToList();
           var result= _country.GetCountry();
            return new JsonResult(result);
        }
        //public readonly ApplicationDbContext applicationDbContext;
        //public CascadeController(ApplicationDbContext dbContext)
        //{
        //    applicationDbContext = dbContext;
        //}

        //public JsonResult GetCountry()
        //{
        //    UserViews userViews = new UserViews();
        //    userViews.countries = applicationDbContext.countries.ToList();

        //       return new JsonResult (userViews);
        //    //}
            //public JsonResult GetState(int countryId)
            //{
            //    UserViews userViews = new UserViews();
            //    userViews.states = applicationDbContext.states.Where(x => x.Country.cntId == countryId).ToList();

            //    return  new JsonResult (userViews);
            //}
            //public JsonResult GetCity(int StateId)
            //{
            //    UserViews userViews = new UserViews();
            //    userViews.cities = applicationDbContext.cities.Where(x => x.State.stId == StateId).ToList();
            //    return new JsonResult (userViews);
            //}
        }
}
