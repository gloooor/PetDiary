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
        public string IsValid { get; set; }

    }
}
