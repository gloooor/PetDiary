using PetDiary.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace PetDiary.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {

        public ObservableCollection<Pet> FilteredPets {
            get => _filteredPets;
            set {
                _filteredPets = value;
                OnPropertyChanged(nameof(FilteredPets));
            }
        }

        private ObservableCollection<Pet> _filteredPets = new ObservableCollection<Pet>();

        public void InitFilters()
        {
            OnFilterChanged(filter);
        }

        private string filter = "";

        public event PropertyChangedEventHandler PropertyChanged;

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

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
