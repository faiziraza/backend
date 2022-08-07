using DAL.DataModel;
using RunnerModel.ModelView;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.IService
{
   public interface IEmployee
    {
        public int AddEmp(EmpModel emp);
        public List<Employee> GetEmp();
        public EmpModel EditEmp(int id);
        public int UpdateEmployee(EmpModel empModel,int id);
        public int DeleteEmployee(int id);

    }
}
