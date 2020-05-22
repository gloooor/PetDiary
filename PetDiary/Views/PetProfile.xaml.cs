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

namespace PetDiary.Views
{
    /// <summary>
    /// Логика взаимодействия для PetProfile.xaml
    /// </summary>
    public partial class PetProfile : Window
    {

        public List<string> myTypes { get; set; }
        public List<string> myGender { get; set; }
        public PetProfile()
        {
            InitializeComponent();
            myTypes = new List<string> { "Dog", "Cat", "Parrot", "Humster" };
            myGender = new List<string> { "Male", "Female" };
            typelist.ItemsSource = myTypes;
            sexlist.ItemsSource = myGender;
            DataContext = ApplicationContext.Get();
        }
    }
}
