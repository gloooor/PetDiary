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
            ViewModel.RegistrationViewModel.User.Password = txtpassword.Password;
        }

        private void btnRegisterCancel_Click(object sender, RoutedEventArgs e)
        {
            var window = new Login();
            window.Show();
            this.Close();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (!ViewModel.RegistrationViewModel.IsValid)
            {
                MessageBox.Show("Sanya privet");
                return;
            }
            var window = new Login();
            window.Show();
            this.Close();
        }

        private void txtpassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            ViewModel.RegistrationViewModel.Password = txtpassword.Password;
        }
    }
}
