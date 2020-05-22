using PetDiary.Command;
using PetDiary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PetDiary.ViewModels
{
    public class RegistrationViewModel: ViewModelBase
    {
        public bool IsValid {
            get => (Login != "" && Password != "");
        }
        public User User { get; set; }
        public void InitUser(bool force = false)
        {
            if (User == null || force)
            {
                User = new User();
            }
        }
        #region Properties
        public string Login {
            get => User.Login;
            set {
                InitUser();
                if (value == null)
                    throw new ArgumentException("Выберите имя");
                else
                {
                    User.Login = value;
                    OnPropertyChanged(nameof(this.Login));
                    OnPropertyChanged(nameof(IsValid));
                }
            }
        }



        public string Password {
            get => this.User.Password;
            set {
                InitUser();
                if (value == null)
                    throw new ArgumentException("Выберите имя");
                else
                {
                    User.Password = value;
                    OnPropertyChanged(nameof(this.Password));
                    OnPropertyChanged(nameof(IsValid));
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
        #endregion
    }

}