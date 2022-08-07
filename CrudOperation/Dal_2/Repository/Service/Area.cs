using Dal_2.Data_Model;
using Dal_2.Repository.Iservice;
using Runner.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dal_2.Repository.Service
{
   public class Area:IArea
    {
        public readonly ApplicationDbContexxt _applicationDbContexxt;
        public Area(ApplicationDbContexxt dbContexxt)
        {
            _applicationDbContexxt = dbContexxt;
        }

        public List<Country2> GetCountry()
        {
            var result = _applicationDbContexxt.countries.ToList();
            return result;
        }
    }
}
