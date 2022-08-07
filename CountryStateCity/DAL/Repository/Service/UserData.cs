using DAL.DataModel;
using DAL.Repository.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repository.Service
{

    public class UserData: ICountry
    {
        public readonly DataContext _context;
        public UserData(DataContext context)
        {
            _context = context;
        }
        public List<Country> GetCountry()
        {
            List<Country> listcountries = new List<Country>();
            listcountries = _context.countries.ToList();
            return listcountries;    
          
        }
        public int Register()
        {
            return  1;
        }


    }
}
