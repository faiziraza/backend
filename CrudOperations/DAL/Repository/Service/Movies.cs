using DAL.DataModel;
using DAL.Repository.IService;
using RunnerModel.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repository.Service
{
    public class Movies : Imovie
    {
        public ApplicationDbContext _DbContext;
        public Movies(ApplicationDbContext context)
        {
            _DbContext = context;
        }
        public int AddMovie(UserView userView)
        {
            try
            {
                Movie Movies = new Movie();
                if(userView!=null)
                {
                    Movies.Title = userView.Title;
                    Movies.Generes = userView.Generes;
                    Movies.Type = userView.Type;
                    Movies.MinimumAge = userView.MinimumAge;
                    _DbContext.Movies.Add(Movies);
                    _DbContext.SaveChanges();
                    return 1;
                }
                else
                { return 0; }

              
            }
            catch (Exception)
            {
                return 0;
                
            }
           
        }
        public List<Movie> GetMoviesDetail()
        {
            List<Movie> movies = new List<Movie>();
            movies = _DbContext.Movies.ToList();

            return movies;
                
        }

        public UserView EditMovie(int id)
        {
            var result = (from x in _DbContext.Movies
                          where x.id == id
                          select new UserView
                          {
                              Generes = x.Generes,
                              Title = x.Title,
                              Type = x.Type,
                              MinimumAge = x.MinimumAge

                          }).FirstOrDefault();
                

            return result;
        }
        public int Update(UserView userView,int id)
        {
            var result = _DbContext.Movies.Where(x => x.id == id).FirstOrDefault();
            result.Generes = userView.Generes;
            result.Title = userView.Title;
            result.Type = userView.Type;
            result.MinimumAge = userView.MinimumAge;
            _DbContext.Movies.Update(result);
            _DbContext.SaveChanges();
            return 1;
        }
 
    }
}
