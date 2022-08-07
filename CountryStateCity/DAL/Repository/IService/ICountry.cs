using DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.IService
{
    public interface ICountry
    {
       
        public List<Country> GetCountry();

        public int Register();
    }
}
