using PetDiary.Models;
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
                      Pets.Add(pet);
                      PetDB.AddPet(pet.Name, pet.Breed, pet.Age, pet.Sex, pet.DateOfBirth, pet.Insured, pet.Desexed, pet.Type, ViewModel.UserViewModel.User.Id);
                  }));
            }
        }

        private RelayCommand _deletePetCommand;
        public RelayCommand DeletePetCommand {
            get {
                return _deletePetCommand ??
                  (_deletePetCommand = new RelayCommand(obj =>
                  {
                      Pets.Remove(SelectedPet);
                      PetDB.DeletePetById(SelectedPet.Id);
                  }));
            }
        }
       
        public void GetUserPets(int userId)
        {
            Pets.Clear();
            var items = PetDB.GetPetsByUserId(userId);
            items.ForEach(Pets.Add);
            if (Pets.Any())
            {
                SelectedPet = Pets.FirstOrDefault();
            }
        }
    }
}
