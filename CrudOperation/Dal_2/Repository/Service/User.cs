using Dal_2.Data_Model;
using Dal_2.Repository.Iservice;
using Runner.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dal_2.Repository.Service
{
    public class User: IuserData
    {
        public readonly ApplicationDbContexxt _applicationDbContexxt;
        public User(ApplicationDbContexxt applicationDbContexxt)
        {
            _applicationDbContexxt = applicationDbContexxt;
        }

        public int AddUser(UserView user)
        {
            UserData userdata = new UserData();
            userdata.Name = user.Name;
            userdata.Email = user.Email;
            userdata.Mobile = user.Mobile;
            userdata.Country2 = user.Country;
            userdata.State2 = user.State;
            userdata.City2 = user.City;
            _applicationDbContexxt.userDatas.Add(userdata);
            _applicationDbContexxt.SaveChanges();
            return 1;
        }
    }
}
