using PetDiary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            typelist.SelectedItem = myTypes[0];
            sexlist.ItemsSource = myGender;
            sexlist.SelectedItem = myGender[0];
            ViewModel.AddPetViewModel.InitPet(true);
            DataContext = ApplicationContext.Get();
        }


        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = !regex.IsMatch(e.Text);
        }

        private void TextBox_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
