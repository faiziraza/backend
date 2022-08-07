using DAL.DataModel;
using DAL.Repository.IServices;
using RunnerModel.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repository.Services
{
    public class StoryBook : IBook
    {
        public readonly ApplicationDbContext _applicationDbContext;
        public StoryBook(ApplicationDbContext dbContext)
        {
            _applicationDbContext = dbContext;
        }
        
        public int MyBook(UserView userView)
        {
            try
            {
                Book book = new Book();
                if (userView !=null)
                {
                    book.Generes = userView.Generes;
                    book.MinimumAge = userView.MinimumAge;
                    book.Title = userView.Title;
                    book.Type = userView.Type;
                    _applicationDbContext.Books.Add(book);
                    _applicationDbContext.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
                
               
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public List<Book>  GetBookDetails()
        {
           List<Book> books = new List<Book>();

            books = _applicationDbContext.Books.ToList();
            return books;
        }
        public  UserView EditDetail(int id)
        {
           
            var result = (from m in _applicationDbContext.Books
                             where m.id ==id
                             select new UserView
                             {
                                 MinimumAge = m.MinimumAge,
                                 Title = m.Title,
                                 Generes = m.Generes,
                                 Type = m.Type
                             }).FirstOrDefault();            
            return result;
        }
        public int UpdateBook(UserView userView,int id)
        {
           var result= _applicationDbContext.Books.Where(x => x.id == id).FirstOrDefault();
            result.MinimumAge = userView.MinimumAge;
            result.Title = userView.Title;
            result.Type = userView.Type;
            result.Generes = userView.Generes;
            _applicationDbContext.Update(result);
            _applicationDbContext.SaveChanges();
            return 1;
        }


    }
}
