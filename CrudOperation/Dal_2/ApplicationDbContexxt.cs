using Dal_2.Data_Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dal_2
{
   public class ApplicationDbContexxt:DbContext
    {
        public ApplicationDbContexxt(DbContextOptions<ApplicationDbContexxt> option) : base(option) { }
        public DbSet<Country2> countries   { get; set; }
        public DbSet<State2> state2s { get; set; }
        public DbSet<City2> city2s { get; set; }
        public DbSet<UserData> userDatas { get; set; }
    }
}
