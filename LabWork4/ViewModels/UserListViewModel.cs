using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LabWork4.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork4.ViewModels
{
    public partial class UserListViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<User> _users = new();

        [ObservableProperty]
        private string? _newLogin;

        [ObservableProperty]
        private string? _newPassword;

        [RelayCommand]
        private void AddUser()
        {
            if (!string.IsNullOrEmpty(NewLogin) && !string.IsNullOrEmpty(NewPassword))
            {
                Users.Add(new User { Login = NewLogin, Password = NewPassword });
                NewLogin = null;
                NewPassword = null;
            }
        }

        [RelayCommand]
        private void DeleteUser(User userToDelete)
        {
            if (userToDelete != null)
            {
                Users.Remove(userToDelete);
            }
        }

        public UserListViewModel()
        {
            Users.Add(new User { Login = "user1", Password = "pass1" });
            Users.Add(new User { Login = "user2", Password = "pass2" });
        }
    }
}
