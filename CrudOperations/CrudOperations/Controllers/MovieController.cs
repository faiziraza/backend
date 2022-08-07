using DAL.Repository.IService;
using Microsoft.AspNetCore.Mvc;
using RunnerModel.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudOperations.Controllers
{
    public class MovieController : Controller
    {
        public readonly Imovie _movie;
        public MovieController(Imovie movie)
        {
            _movie = movie;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddMovie()
        { 
            return View( );

        }
        [HttpPost]
        public IActionResult AddMovie(UserView userView,List<string> GenersList)
        {
            string Gener = string.Join(",", GenersList);
            userView.Generes = Gener;
          var result=  _movie.AddMovie(userView);
            return View(result);
        }
        public IActionResult GetMovie()
        {
            var res = _movie.GetMoviesDetail( );
            return View(res);

        }
        public IActionResult EditMovie(int id)
        {
           var x= _movie.EditMovie(id);
            TempData["MovieId"] = id;

            return View(x);
        }
        [HttpPost]
        public IActionResult UpdateMovie(UserView userView ,List<string> GnenersList)
        {
            int id = (int)TempData["MovieId"];
            string gener = string.Join(",", GnenersList);
            userView.Generes = gener;

           var x= _movie.Update(userView, id);

            return RedirectToAction("EditMovie");
        }
       
        
    }
}
