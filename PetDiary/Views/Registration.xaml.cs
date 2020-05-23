using PetDiary.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace PetDiary
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {

        public Registration()
        {
            InitializeComponent();

            ViewModel.RegistrationViewModel.InitUser(true);
            DataContext = ApplicationContext.Get();
        }

        private void pwBoxUser2_PasswordChanged(object sender, RoutedEventArgs e)
        {
            var pBox = sender as PasswordBox;
            string blank = pBox.Password;
            RegistrationViewModel.counter = blank.Length;
            var sMD6 = DB.Hash(blank);
            blank = "";
            MD6pw.Text = sMD6;
        }
    }
}