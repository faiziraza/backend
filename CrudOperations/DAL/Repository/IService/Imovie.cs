using DAL.DataModel;
using RunnerModel.ModelView;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.IService
{
  public  interface Imovie
    {
        public int AddMovie(UserView userView);
        public List<Movie> GetMoviesDetail();
        public UserView EditMovie(int id);
        public int Update(UserView userView, int id);
    }
}
