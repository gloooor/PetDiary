using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using PetDiary.Models;
using PetDiary.DataBase;
using PetDiary.ViewModels;

namespace PetDiary
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {

        public Login()
        {
            InitializeComponent();
            ViewModel.RegistrationViewModel.InitUser(true);
            DataContext = ApplicationContext.Get();
        }

        private void pwBoxUser_PasswordChanged(object sender, RoutedEventArgs e)
        {
            var pBox = sender as PasswordBox;
            string blank = pBox.Password;
            var sMD5 = DB.Hash(blank);
            blank = "";
            MD5pw.Text = sMD5;
        }
    }
}