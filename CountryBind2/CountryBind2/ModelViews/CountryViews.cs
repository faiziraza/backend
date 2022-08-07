using CountryBind2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryBind2.ModelViews
{
    public class CountryViews
    {
        public string State_Name { get; set; }

        public string Country_Name { get; set; }
        public List<Country> countries   { get; set; }
        public List<State>  states { get; set; }
    }
}
