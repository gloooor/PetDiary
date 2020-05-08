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
    public class ActivityNoteViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<ActivityNote> ActivityNotes {
            get => _activityNotes;
            set {
                _activityNotes = value;
                OnPropertyChanged(nameof(ActivityNotes));
            }
        }
       
        private ObservableCollection<ActivityNote> _activityNotes;
        private readonly ActivityNoteDB _activityDB = new ActivityNoteDB();


        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public ActivityNoteViewModel()
        {
            ActivityNotes = new ObservableCollection<ActivityNote>();
        }

        private RelayCommand _addActivityNoteCommand;
        public RelayCommand AddActivityCommand {
            get {
                return _addActivityNoteCommand ??
                  (_addActivityNoteCommand = new RelayCommand(obj =>
                  {
                      var note = ViewModel.ReportActivityViewModel.Note;
                      ActivityNotes.Add(note);
                      ActivityNoteDB.AddNote(note.Date, note.Location, note.Hours, note.Minutes, note.Comment, note.Rating, ViewModel.PetViewModel.SelectedPet.Id);
                  }));
            }
        }
        public void GetPetActivityNotes(int petId)
        {
            ActivityNotes.Clear();
            var items = _activityDB.GetNotesByPetId(petId);
            items.ForEach(ActivityNotes.Add);
        }
    }
}
