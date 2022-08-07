using DAL.DataModel;
using DAL.Repository.IService;
using RunnerModel.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repository.Service
{
   public class RepoEmployee : IEmployee
    {
        public readonly ApplicationDbContext _Application;
        public RepoEmployee(ApplicationDbContext context)
        {
            _Application = context;
        }

        public int AddEmp(EmpModel emp )
        {
            Employee employee = new Employee();
            employee.Name = emp.Name;
            employee.Email = emp.Email;
            employee.Mobile = emp.Mobile;
            var res = _Application.Employees_e.Add(employee);
            _Application.SaveChanges();
           

            return 1;
        }

        public List<Employee> GetEmp()
        {
            List<Employee> employees = new List<Employee>();
            employees = _Application.Employees_e.ToList();
            return employees;
        }
        public EmpModel EditEmp(int id)
        {
            var result = (from m in _Application.Employees_e
                          where m.id == id
                          select new EmpModel
                          {
                              Name = m.Name,
                              Email = m.Email,
                              mobile = m.Mobile


                          }).FirstOrDefault();


            return result;
        }
        public int UpdateEmployee(EmpModel empModel,int id)
        {
            var x = _Application.Employees_e.Where(m => m.Id == id).FirstOrDefault();
            x.Name = empModel.Name;
            x.Email = empModel.Email;
            x.Mobile = empModel.Email;
            _Application.Employees_e.Update(x);
            _Application.SaveChanges();
            return 1;
        }
        public int DeleteEmployee(int id)
        {
            var remove=_Application.Employees_e.Find(id);
            _Application.Employees_e.Remove(remove);
            _Application.SaveChanges();
            return 1;
        }

        public int DeleteEmployee(EmpModel empModel)
        {
            throw new NotImplementedException();
        }
    }
          
    
    
}
