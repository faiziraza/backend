using DAL.DataModel;
using RunnerModel.ModelView;
using System.Collections.Generic;

namespace DAL.Repository.IServices
{
    public interface IBook
    {
        public int MyBook(UserView userView);
        public List<Book> GetBookDetails();
        public UserView EditDetail( int id);
        public int UpdateBook(UserView userView,int id);
    }

   
     
}
