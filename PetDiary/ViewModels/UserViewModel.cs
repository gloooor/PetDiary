using PetDiary.Command;
using PetDiary.DataBase;
using PetDiary.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PetDiary.ViewModels
{
    public class UserViewModel : ViewModelBase
    {
        public User User {
            get => _user;
            set {
                _user = value;
                OnPropertyChanged(nameof(User));
            }
        }
        private User _user;
        public ObservableCollection<User> Users {
            get => _users;
            set {
                _users = value;
                OnPropertyChanged(nameof(Users));
            }
        }

        private ObservableCollection<User> _users;
        public UserViewModel()
        {
            Users = new ObservableCollection<User>();
        }
        User _selectedUser;

        public User SelectedUser {
            get {
                return _selectedUser;
            }
            set {
                _selectedUser = value;
                OnPropertyChanged("SelectedUser");
            }
        }



        #region Commands
        private RelayCommand _addUserCommand;
        public RelayCommand AddUserCommand {
            get {
                return _addUserCommand ??
                  (_addUserCommand = new RelayCommand(obj =>
                  {

                      var user = ViewModel.RegistrationViewModel.User;
                      if (user.Login.Length < 8 || user.Login.Length > 20)
                      {
                          MessageBox.Show("The login must be between 8 and 20 characters long");
                          return;
                      };
                      if (RegistrationViewModel.counter < 8 || RegistrationViewModel.counter > 20)
                      {
                          MessageBox.Show("The password must be between 8 and 20 characters long");
                          return;
                      };
                      UserDB.AddUser(user.Login, user.Password);
                      var win = new Login();
                      win.Show();
                      foreach (System.Windows.Window window in System.Windows.Application.Current.Windows)
                      {
                          if (System.Windows.Application.Current.Windows.Count > 1)
                              window.Close();
                      }
                  }));
            }
        }
        private RelayCommand _deleteUserCommand;
        public RelayCommand DeleteUserCommand {
            get {
                return _deleteUserCommand ??
                  (_deleteUserCommand = new RelayCommand(obj =>
                  {
                      if (ViewModel.UserViewModel.SelectedUser != null)
                      {
                          UserDB.DeleteUserById(ViewModel.UserViewModel.SelectedUser.Id);
                          Users.Remove(ViewModel.UserViewModel.SelectedUser);
                      }
                  }));
            }
        }
        private RelayCommand _createAdminCommand;
        public RelayCommand CreateAdminCommand {
            get {
                return _createAdminCommand ??
                  (_createAdminCommand = new RelayCommand(obj =>
                  {
                      if (ViewModel.UserViewModel.SelectedUser != null)
                      {
                          UserDB.UpdateUserById(ViewModel.UserViewModel.SelectedUser.Id);
                          Users.Remove(ViewModel.UserViewModel.SelectedUser);
                      }
                  }));
            }
        }
        #endregion
        #region Methods
        public void GetUsers()
        {
            Users.Clear();
            var items = UserDB.GetUsers();
            items.ForEach(Users.Add);
        }
        #endregion
    }
}