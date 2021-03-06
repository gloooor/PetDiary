﻿using PetDiary.Command;
using PetDiary.Models;
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
using System.Windows.Data;

namespace PetDiary.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

        public ObservableCollection<Pet> FilteredPets {
            get => _filteredPets;
            set {
                _filteredPets = value;
                OnPropertyChanged(nameof(FilteredPets));
            }
        }

        private ObservableCollection<Pet> _filteredPets = new ObservableCollection<Pet>();
        private string filter = "";

        public string Filter {
            get { return this.filter; }
            set {
                if (this.Filter == value)
                {
                    return;
                }
                this.filter = value;
                OnFilterChanged(value);
                OnPropertyChanged(nameof(Filter));
            }
        }

        Pet _selectedPet;

        public Pet SelectedPet {
            get {
                return _selectedPet;
            }

            set {
                _selectedPet = value;
                OnPropertyChanged("SelectedPet");
            }
        }

        #region Methods
        public void InitFilters()
        {
            OnFilterChanged(filter);
        }
        private void OnFilterChanged(string filter)
        {
            FilteredPets.Clear();
            if (string.IsNullOrWhiteSpace(filter))
            {
                ViewModel.PetViewModel.Pets.ToList().ForEach(FilteredPets.Add);
            }
            else
            {
                var items = ViewModel.PetViewModel.Pets.Where(svm => svm.Name.Contains(filter) || svm.Age.ToString().Contains(filter)).ToList();
                items.ForEach(FilteredPets.Add);
            }
            SelectedPet = FilteredPets.FirstOrDefault();
            if (SelectedPet == null)
            {
                return;
            }
            ViewModel.ActivityNoteViewModel.GetPetActivityNotes(SelectedPet.Id);
            ViewModel.FeedingNoteViewModel.GetPetFeedingNotes(SelectedPet.Id);
        }
        #endregion
        #region Commands
        private RelayCommand _cancelWindowCommand;
        public RelayCommand CancelWindowCommand {
            get {
                return _cancelWindowCommand ??
                  (_cancelWindowCommand = new RelayCommand(obj =>
                  {
                      var win = new MainWindow();
                      win.Show();
                      foreach (System.Windows.Window window in System.Windows.Application.Current.Windows)
                      {
                          if (System.Windows.Application.Current.Windows.Count > 1)
                              window.Close();
                      }

                  }));
            }
        }

        private RelayCommand _aboutCommand;
        public RelayCommand AboutCommand {
            get {
                return _aboutCommand ??
                  (_aboutCommand = new RelayCommand(obj =>
                  {
                      var win = new About();
                      win.Show();
                      foreach (System.Windows.Window window in System.Windows.Application.Current.Windows)
                      {
                          if (System.Windows.Application.Current.Windows.Count > 1)
                              window.Close();
                      }

                  }));
            }
        }

        private RelayCommand _openAddPetCommand;
        public RelayCommand OpenAddPetCommand {
            get {
                return _openAddPetCommand ??
                  (_openAddPetCommand = new RelayCommand(obj =>
                  {
                      var win = new AddPet();
                      win.Show();
                      foreach (System.Windows.Window window in System.Windows.Application.Current.Windows)
                      {
                          if (System.Windows.Application.Current.Windows.Count > 1)
                              window.Close();
                      }

                  }));
            }
        }

        private RelayCommand _openReportFeedingCommand;
        public RelayCommand OpenReportFeedingCommand {
            get {
                return _openReportFeedingCommand ??
                  (_openReportFeedingCommand = new RelayCommand(obj =>
                  {
                      if (!ViewModel.MainWindowViewModel.FilteredPets.Any())
                      {
                          MessageBox.Show("Create some pet");
                          return;
                      }
                      var win = new ReportFeeding();
                      win.Show();
                      foreach (System.Windows.Window window in System.Windows.Application.Current.Windows)
                      {
                          if (System.Windows.Application.Current.Windows.Count > 1)
                              window.Close();
                      }

                  }));
            }
        }

        private RelayCommand _openReportActivityCommand;
        public RelayCommand OpenReportActivityCommand {
            get {
                return _openReportActivityCommand ??
                  (_openReportActivityCommand = new RelayCommand(obj =>
                  {
                      if (!ViewModel.MainWindowViewModel.FilteredPets.Any())
                      {
                          MessageBox.Show("Create some pet");
                          return;
                      }
                      var win = new ReporlActivity();
                      win.Show();
                      foreach (System.Windows.Window window in System.Windows.Application.Current.Windows)
                      {
                          if (System.Windows.Application.Current.Windows.Count > 1)
                              window.Close();
                      }

                  }));
            }
        }

        private RelayCommand _openStatisticCommand;
        public RelayCommand OpenStatisticCommand {
            get {
                return _openStatisticCommand ??
                  (_openStatisticCommand = new RelayCommand(obj =>
                  {
                      if (!ViewModel.MainWindowViewModel.FilteredPets.Any())
                      {
                          MessageBox.Show("Create some pet");
                          return;
                      }
                      var win = new Statistics();
                      win.Show();
                      foreach (System.Windows.Window window in System.Windows.Application.Current.Windows)
                      {
                          if (System.Windows.Application.Current.Windows.Count > 1)
                              window.Close();
                      }

                  }));
            }
        }

        private RelayCommand _openProfileCommand;
        public RelayCommand OpenProfileCommand {
            get {
                return _openProfileCommand ??
                  (_openProfileCommand = new RelayCommand(obj =>
                  {
                      if (!ViewModel.MainWindowViewModel.FilteredPets.Any())
                      {
                          MessageBox.Show("Create some pet");
                          return;
                      }
                      var win = new PetProfile();
                      win.Show();
                      foreach (System.Windows.Window window in System.Windows.Application.Current.Windows)
                      {
                          if (System.Windows.Application.Current.Windows.Count > 1)
                              window.Close();
                      }

                  }));
            }
        }
        private RelayCommand _openLogInCommand;
        public RelayCommand OpenLogInCommand {
            get {
                return _openLogInCommand ??
                  (_openLogInCommand = new RelayCommand(obj =>
                  {
                      var win = new Login();
                      win.Show();
                      foreach (System.Windows.Window window in System.Windows.Application.Current.Windows)
                      {
                          if (System.Windows.Application.Current.Windows.Count > 1)
                              window.Close();
                      }
                      ViewModel.ActivityNoteViewModel.ActivityNotes.Clear();
                      ViewModel.FeedingNoteViewModel.FeedingNotes.Clear();
                      ViewModel.PetViewModel.Pets.Clear();

                  }));
            }
        }
        private RelayCommand _closeCommand;
        public RelayCommand CloseCommand {
            get {
                return _closeCommand ??
                  (_closeCommand = new RelayCommand(obj =>
                  {

                      foreach (System.Windows.Window window in System.Windows.Application.Current.Windows)
                      {
                          window.Close();
                      }

                  }));
            }
        }
        #endregion
      
    }
}
