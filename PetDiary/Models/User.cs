using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PetDiary.Models
{
    public class User
    {   
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

       public  User( string Login, int Id, string Password, bool IsAdmin)
        {
            this.Id = Id;
            this.Login = Login;
            this.Password = Password;
            this.IsAdmin = IsAdmin;
        }
        public User()
        {
            this.Id = 0;
            this.Login = "";
            this.Password ="";
            this.IsAdmin = false;
        }
    }
}
