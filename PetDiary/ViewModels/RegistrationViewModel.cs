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
    public class RegistrationViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
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


        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }

}
