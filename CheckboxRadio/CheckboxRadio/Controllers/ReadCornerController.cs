using DAL.Repository.IServices;
using Microsoft.AspNetCore.Mvc;
using RunnerModel.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckboxRadio.Controllers
{
    public class ReadCornerController : Controller
    {
        public readonly IBook _book;
        public ReadCornerController(IBook book)
        {
            _book = book;
        }

        //public IActionResult Index()
        //{
            
        //    return View();
        //}
        public IActionResult ReadingBook()
            {
            return View();
        }
        [HttpPost]
        public ActionResult ReadingBooks( UserView userView, List<string> GeneresList)
        {
            try
            {
                string Generes = string.Join(",", GeneresList);
                userView.Generes = Generes;
                var result = _book.MyBook(userView);
                //var res = _book.GetBookDetails();
                   return RedirectToAction("GetDetails");
                
            }
            catch (Exception)
            {
                throw;
                
            }
           
        }
        public IActionResult GetDetails( )
        {   
           var rst = _book.GetBookDetails();
            return View(rst);
        }
       
        public IActionResult EditDetail(int id)
        {
            var x = _book.EditDetail(id);
            TempData["bookid"] = id;
            return View(x);
        }
        [HttpPost]
        public IActionResult UpdateBook(UserView userView,List<string> GeneresList)
        {
            int idsss = (int)TempData["bookid"];
            string Generes = string.Join(",", GeneresList);
            userView.Generes = Generes;
                var x = _book.UpdateBook(userView, idsss);

            //_book.;
            return RedirectToAction("EditDetail");
        }

    }  


}
