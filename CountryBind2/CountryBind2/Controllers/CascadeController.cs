using CountryBind2.Models;
using CountryBind2.ModelViews;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryBind2.Controllers
{
    
    public class CascadeController : Controller
    {
        public readonly ApplicationDbContext _context;

        public CascadeController (ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            //List<Country> cnt = new List<Country>();

            CountryViews countryViews1 = new CountryViews();
           countryViews1.countries = _context.Countries.ToList();
            countryViews1.states = _context.States.ToList();
            return View(countryViews1);
        }

        public IActionResult GetCountry()
        {
            CountryViews countryViews1 = new CountryViews();
            countryViews1.countries = _context.Countries.ToList();
            return Json(countryViews1);
        }

    }
}
