using PetDiary.Command;
using PetDiary.DataBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PetDiary.ViewModels
{
    public class FeedingNoteViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<FeedingNote> FeedingNotes {
            get => _feedingNotes;
            set {
                _feedingNotes = value;
                OnPropertyChanged(nameof(FeedingNotes));
            }
        }

        private ObservableCollection<FeedingNote> _feedingNotes;
        private readonly FeedingNoteDB _feedingDB = new FeedingNoteDB();


        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


        private RelayCommand _addFeedingNoteCommand;
        public RelayCommand AddFeedingCommand {
            get {
                return _addFeedingNoteCommand ??
                  (_addFeedingNoteCommand = new RelayCommand(obj =>
                  {
                      var note = ViewModel.ReportFeedingViewModel.FeedingNote;
                      FeedingNotes.Add(note);
                      FeedingNoteDB.AddNote(note.Date, note.WetFood, note.DryFood, note.Meat, note.Medicines, note.Other, ViewModel.PetViewModel.SelectedPet.Id);
                  }));
            }
        }
        public FeedingNoteViewModel()
        {
            FeedingNotes = new ObservableCollection<FeedingNote>();
        }
        public void GetPetFeedingNotes(int petId)
        {
            FeedingNotes.Clear();
            var items = _feedingDB.GetNotesByPetId(petId);
            items.ForEach(FeedingNotes.Add);
        }

    }
}
