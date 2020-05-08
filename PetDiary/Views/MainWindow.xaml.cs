using PetDiary.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PetDiary
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ViewModel.PetViewModel.GetUserPets(ViewModel.UserViewModel.User.Id);
            RefreshNotes();

            DataContext = ApplicationContext.Get();

        }
        private void RefreshNotes()
        {
            if (ViewModel.PetViewModel.SelectedPet?.Id == null)
            {
                return;
            }
            ViewModel.ActivityNoteViewModel.GetPetActivityNotes(ViewModel.PetViewModel.SelectedPet.Id);
            ViewModel.FeedingNoteViewModel.GetPetFeedingNotes(ViewModel.PetViewModel.SelectedPet.Id);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new AddPet();
            window.Show();
            this.Close();
        }

        private void del(object sender, RoutedEventArgs e)
        {
            var window = new Login();
            window.Show();
            this.Close();
        }

        private void clo(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void petsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!ViewModel.PetViewModel.Pets.Any())
            {
                ViewModel.PetViewModel.SelectedPet = null;
                return;
            }
            var index = petsList.SelectedIndex;
            if (index >= ViewModel.PetViewModel.Pets.Count || index < 0)
            {
                index = 0;
            }
            ViewModel.PetViewModel.SelectedPet = ViewModel.PetViewModel.Pets[index];
            RefreshNotes();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var window = new ReporlActivity();
            window.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var window = new ReportFeeding();
            window.Show();
            this.Close();
        }
    }
}
