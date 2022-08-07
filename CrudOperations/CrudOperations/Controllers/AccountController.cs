using DAL.Repository.IService;
using Microsoft.AspNetCore.Mvc;
using RunnerModel.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudOperations.Controllers
{
    public class AccountController : Controller
    {
        public readonly IEmployee _empl;
        public AccountController(IEmployee employee)
        {
            _empl = employee;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult AddEmployee()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult CreateEmployee(EmpModel emp)
        {
            if(ModelState.IsValid)
            {
                var res = _empl.AddEmp(emp);
                if (res == 1)
                {
                    return RedirectToAction("GetEmployee");
                }
                else
                {
                    return View("AddEmployee");
                }
                
            }
            return View("AddEmployee");
          
            
        }
        public IActionResult GetEmployee()
        {
          var result=  _empl.GetEmp();
            return View(result);
        }
        public IActionResult EditEmployee(int id)
        {
            var res = _empl.EditEmp(id);
            TempData["empId"] = id;
            return View("EditEmployee",res);
           
        }
        [HttpPost]
        public IActionResult UpdateEmp(EmpModel empModel)
        {
          int  id = (int)TempData["empId"];
            var x = _empl.UpdateEmployee(empModel,id);
            return RedirectToAction("GetEmployee"); 
        }
        public IActionResult DeleteEmp(int id)
        {
            _empl.DeleteEmployee(id);
            
            return RedirectToAction("GetEmployee");
        }
       
       
    }
}
