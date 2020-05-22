using PetDiary.ViewModels;
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

namespace PetDiary
{
    /// <summary>
    /// Логика взаимодействия для AddPet.xaml
    /// </summary>
    public partial class AddPet : Window
    {
        public List<string> myTypes { get; set; }
        public List<string> myGender { get; set; }
        public AddPet()
        {
            InitializeComponent();
            myTypes = new List<string> { "Dog", "Cat", "Rabbit", "Hamster" };
            myGender = new List<string> { "Male", "Female"};
            typelist.ItemsSource = myTypes;
            sexlist.ItemsSource = myGender;
            ViewModel.AddPetViewModel.InitPet(true);
            DataContext = ApplicationContext.Get();
        }

        private void butcancelpet_Click(object sender, RoutedEventArgs e)
        {
            var window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void txtbreed_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
