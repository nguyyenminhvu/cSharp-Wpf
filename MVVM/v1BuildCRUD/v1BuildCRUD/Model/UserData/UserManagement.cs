using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using v1BuildCRUD.Model.UserModel;

namespace v1BuildCRUD.Model.UserData
{
    public class UserManagement
    {
        public UserManagement() { }


        private static ObservableCollection<UserModel.Users> users = new ObservableCollection<UserModel.Users>() {
            new UserModel.Users{ Id=Guid.NewGuid(),DateCreate=DateTime.Now,Name="Steve" },
            new UserModel.Users{ Id=Guid.NewGuid(),DateCreate=DateTime.Now,Name="Stark" },
            new UserModel.Users{ Id=Guid.NewGuid(),DateCreate=DateTime.Now,Name="Ronaldo" },
            new UserModel.Users{ Id=Guid.NewGuid(),DateCreate=DateTime.Now,Name="Pojo" },
            new UserModel.Users{ Id=Guid.NewGuid(),DateCreate=DateTime.Now,Name="Cs" },
        };

        public  ObservableCollection<Users> GetUsers() { return users; }
    }
}
