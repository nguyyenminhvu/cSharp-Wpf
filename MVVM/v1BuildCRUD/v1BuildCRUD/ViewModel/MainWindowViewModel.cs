using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using v1BuildCRUD.Model.UserData;
using v1BuildCRUD.Model.UserModel;

namespace v1BuildCRUD.ViewModel
{
    public class MainWindowViewModel
    {
        public ObservableCollection<Users> users;
        private UserManagement _userManagement;
        public MainWindowViewModel()
        {
            _userManagement = new UserManagement();
            users =_userManagement.GetUsers();
        }

    }
}
