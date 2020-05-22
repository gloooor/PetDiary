﻿using PetDiary.Models;
using PetDiary.DataBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PetDiary.Command;
using System.Windows;
using System.Diagnostics;

namespace PetDiary.ViewModels
{
    public class PetViewModel : INotifyPropertyChanged
    {


        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Pet> Pets {
            get => _pets;
            set {
                _pets = value;
                OnPropertyChanged(nameof(Pets));
            }
        }

        private ObservableCollection<Pet> _pets;
        private readonly PetDB _petDB = new PetDB();
       

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public PetViewModel()
        {
            Pets = new ObservableCollection<Pet>();
        }




        private RelayCommand _addPetCommand;
        public RelayCommand AddPetCommand {
            get {
                return _addPetCommand ??
                  (_addPetCommand = new RelayCommand(obj =>
                  {
                      var pet = ViewModel.AddPetViewModel.Pet;
                      ViewModel.MainWindowViewModel.FilteredPets.Add(pet);
                      Pets.Add(pet);
                      PetDB.AddPet(pet.Name, pet.Breed, pet.Age, pet.Sex, pet.DateOfBirth, pet.Insured, pet.Desexed, pet.Type, ViewModel.UserViewModel.User.Id);
                      if (ViewModel.UserViewModel.User != null)
                      {
                          GetUserPets(ViewModel.UserViewModel.User.Id);
                      }
                      var win = new MainWindow();
                      win.Show();
                      foreach (System.Windows.Window window in System.Windows.Application.Current.Windows)
                      { if(System.Windows.Application.Current.Windows.Count>1)
                              window.Close();
                      }
                     
                  }));
            }
        }
      
        private RelayCommand _deletePetCommand;
        public RelayCommand DeletePetCommand {
            get {
                return _deletePetCommand ??
                  (_deletePetCommand = new RelayCommand(obj =>
                  {
                      if (ViewModel.MainWindowViewModel.SelectedPet != null)
                      {
                          PetDB.DeletePetById(ViewModel.MainWindowViewModel.SelectedPet.Id);
                          ViewModel.MainWindowViewModel.FilteredPets.Remove(ViewModel.MainWindowViewModel.SelectedPet);
                          ViewModel.MainWindowViewModel.SelectedPet =  ViewModel.MainWindowViewModel.FilteredPets.FirstOrDefault();
                          Pets.Remove(ViewModel.MainWindowViewModel.SelectedPet);
                      }
                  }));
            }
        }
        private RelayCommand changePetCommand;
        public RelayCommand ChangePetCommand => this.changePetCommand ??
            (this.changePetCommand = new RelayCommand(obj =>
            {
                var pet = ViewModel.MainWindowViewModel.SelectedPet;
                PetDB.UpdatePet(pet.Id, pet.Name, pet.Breed, pet.Age, pet.Sex, pet.DateOfBirth, pet.Insured, pet.Desexed, pet.Type);

            }
            ));

            private RelayCommand changePetCancelCommand;
        public RelayCommand ChangePetCancelCommand => this.changePetCancelCommand ??
            (this.changePetCancelCommand = new RelayCommand(obj =>
            {
                var pet = ViewModel.MainWindowViewModel.SelectedPet;
                PetDB.UpdatePet(pet.Id, pet.Name, pet.Breed, pet.Age, pet.Sex, pet.DateOfBirth, pet.Insured, pet.Desexed, pet.Type);

                var win = new MainWindow();
                win.Show();
                foreach (System.Windows.Window window in System.Windows.Application.Current.Windows)
                {
                    if (System.Windows.Application.Current.Windows.Count > 1)
                        window.Close();
                }
            }
            ));

        public void GetUserPets(int userId)
        {
            Pets.Clear();
            var items = PetDB.GetPetsByUserId(userId);
            items.ForEach(Pets.Add);
            ViewModel.MainWindowViewModel.InitFilters();
        }
    }
}
