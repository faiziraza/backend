using Runner.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dal_2.Repository.Iservice
{
    public interface IuserData
    {
        public int AddUser(UserView user);
    }
}
