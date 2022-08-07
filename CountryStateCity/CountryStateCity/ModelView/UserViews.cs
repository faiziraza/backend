using CountryStateCity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryStateCity.ModelView
{
    public class UserViews
    {
        public string CountryName { get; set; }
        public string StateName { get; set; }
        public string CityName { get; set; }
        public List<Country> countries { get; set; }
        public List<State> states { get; set; }
        public List<City> cities { get; set; }
    }
}
