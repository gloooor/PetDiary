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

        public UserViewModel UserViewModel { get; set; }

        private readonly UserDB _userDB;
        public Login()
        {
            InitializeComponent();
            _userDB = new UserDB();
            UserViewModel = ViewModel.UserViewModel;
        }

       
       
        private void butLogin_Click(object sender, RoutedEventArgs e)
        {
            var hash = DB.Hash(txtpassword.Password);
            var user = _userDB.GetUserByFirstNameAndLastName(txtfirstname.Text, txtlastname.Text);

            if (user.Password!=hash)
            {
                MessageBox.Show("невалидный юзер");
                return; 
            }
            UserViewModel.User = user;
            var window= new MainWindow();
            window.Show();
            this.Close();
        }

        private void butRegister_Click(object sender, RoutedEventArgs e)
        {
            Registration Menu = new Registration();
            Menu.Show();
            this.Close();
        }
    }
}
