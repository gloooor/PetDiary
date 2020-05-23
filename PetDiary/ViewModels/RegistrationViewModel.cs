using PetDiary.Command;
using PetDiary.DataBase;
using PetDiary.Models;
using PetDiary.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PetDiary.ViewModels
{
    public class RegistrationViewModel : ViewModelBase, IDataErrorInfo
    {

        public User User { get; set; }
        public void InitUser(bool force = false)
        {
            if (User == null || force)
            {
                User = new User();
            }
        }
        static public int counter = 0;
        #region Validation
        public string this[string columnName] {
            get {
                string error = String.Empty;
                switch (columnName)
                {
                    case "Login":
                        if (User.Login == null)
                        {
                            break;
                        }
                        else if ((User.Login.Length < 8) || (User.Login.Length > 20))
                        {
                            error = "The login must be between 8 and 20 characters long";
                        }
                        break;
                    case "Password":
                        if (User.Password == null)
                        {
                            error = "Enter password";
                        }
                        else if ((User.Password.Length < 8) || (User.Password.Length > 20))
                        {
                            error = "The password must be between 8 and 20 characters long";
                        }
                        break;

                }
                return error;
            }
        }
        public string Error {
            get { throw new NotImplementedException(); }
        }

        #endregion
        #region Properties
        public string Login {

            get => User.Login;
            set {
                InitUser();
                if (value != "" || value.Length > 8 || value.Length < 20)
                {
                    User.Login = value;
                    OnPropertyChanged(nameof(this.Login));
                }

            }
        }
        public string Password {
            get => this.User.Password;
            set {
                InitUser();
                if (value != "" || value.Length > 8 || value.Length < 20)
                {
                    User.Password = value;
                    OnPropertyChanged(nameof(this.Password));
                }

            }
        }
        #endregion
        #region Commands
        private RelayCommand _cancelRegistrationCommand;
        public RelayCommand CancelRegistrationCommand {
            get {
                return _cancelRegistrationCommand ??
                  (_cancelRegistrationCommand = new RelayCommand(obj =>
                  {
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

        private RelayCommand _openRegistrationCommand;
        public RelayCommand OpenRegistrationCommand {
            get {
                return _openRegistrationCommand ??
                  (_openRegistrationCommand = new RelayCommand(obj =>
                  {
                      var win = new Registration();
                      win.Show();
                      foreach (System.Windows.Window window in System.Windows.Application.Current.Windows)
                      {
                          if (System.Windows.Application.Current.Windows.Count > 1)
                              window.Close();
                      }

                  }));
            }
        }

        private RelayCommand _registrationCommand;
        public RelayCommand RegistrationCommand {
            get {
                return _registrationCommand ??
                  (_registrationCommand = new RelayCommand(obj =>
                  {
                      if (User.Login.Length < 8 || User.Login.Length > 20)
                      {
                          MessageBox.Show("The login must be between 8 and 20 characters long");
                          return;
                      };
                      var user = UserDB.GetUserByLogin(User.Login);
                      if (user != null)
                      {
                          if (user.Password == ViewModel.RegistrationViewModel.User.Password)
                          {
                              ViewModel.UserViewModel.User = user;
                              if (ViewModel.UserViewModel.User.IsAdmin == true)
                              {
                                  var win = new AdminPage();
                                  win.Show();
                              }
                              else
                              {
                                  var win = new MainWindow();
                                  win.Show();
                              }
                              foreach (System.Windows.Window window in System.Windows.Application.Current.Windows)
                              {
                                  if (System.Windows.Application.Current.Windows.Count > 1)
                                      window.Close();
                              }
                          }
                          else
                          {
                              MessageBox.Show("Check your password");
                          }
                      }
                      else
                      {
                          MessageBox.Show("Login is not found");
                      }


                  }));
            }
        }
        #endregion
    }

}