using PetDiary.ViewModels;
using PetDiary.Views;
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
            if (ViewModel.MainWindowViewModel.SelectedPet ==null)
            {
                return;
            }
            ViewModel.ActivityNoteViewModel.GetPetActivityNotes(ViewModel.MainWindowViewModel.SelectedPet.Id);
            ViewModel.FeedingNoteViewModel.GetPetFeedingNotes(ViewModel.MainWindowViewModel.SelectedPet.Id);
        }
        private void petsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!ViewModel.MainWindowViewModel.FilteredPets.Any())
            {
                return;
            }
            var index = petsList.SelectedIndex;
            if (index >= ViewModel.MainWindowViewModel.FilteredPets.Count || index < 0)
            {
                index = 0;
            }
            ViewModel.MainWindowViewModel.SelectedPet = ViewModel.MainWindowViewModel.FilteredPets[index];
            RefreshNotes();
        }

        private void ActList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!ViewModel.ActivityNoteViewModel.ActivityNotes.Any())
            {
                ViewModel.ActivityNoteViewModel.SelectedActivityNote = null;
                return;
            }
            var index = actList.SelectedIndex;
            if (index >= ViewModel.ActivityNoteViewModel.ActivityNotes.Count || index < 0)
            {
                index = 0;
            }
            ViewModel.ActivityNoteViewModel.SelectedActivityNote = ViewModel.ActivityNoteViewModel.ActivityNotes[index];
        }
        private void FeedList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!ViewModel.FeedingNoteViewModel.FeedingNotes.Any())
            {
                ViewModel.FeedingNoteViewModel.SelectedFeedingNote = null;
                return;
            }
            var index = feedList.SelectedIndex;
            if (index >= ViewModel.FeedingNoteViewModel.FeedingNotes.Count || index < 0)
            {
                index = 0;
            }
            ViewModel.FeedingNoteViewModel.SelectedFeedingNote = ViewModel.FeedingNoteViewModel.FeedingNotes[index];
        }
    }
}
