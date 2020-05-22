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
    public class ActivityNoteViewModel : INotifyPropertyChanged
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

                      if (ViewModel.MainWindowViewModel.SelectedPet != null)
                      {
                          ActivityNoteDB.AddNote(note.Date, note.Location, note.Hours, note.Minutes, note.Comment, note.Rating, ViewModel.MainWindowViewModel.SelectedPet.Id);
                          GetPetActivityNotes(ViewModel.MainWindowViewModel.SelectedPet.Id);
                      }
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

        private RelayCommand _deleteActivityNoteCommand;
        public RelayCommand DeleteActivityNoteCommand {
            get {
                return _deleteActivityNoteCommand ??
                  (_deleteActivityNoteCommand = new RelayCommand(obj =>
                  {
                      if (SelectedActivityNote != null)
                      {
                          ActivityNoteDB.DeleteNoteById(SelectedActivityNote.Id);
                          ActivityNotes.Remove(SelectedActivityNote);
                          SelectedActivityNote = ActivityNotes.FirstOrDefault();
                      }
                  }));
            }
        }

        private RelayCommand sortActivityCommand;

        public RelayCommand SortActivityCommand => this.sortActivityCommand ??
                    (this.sortActivityCommand = new RelayCommand(obj =>
                    {
                        ActivityNotes = new ObservableCollection<ActivityNote>(this.ActivityNotes.OrderBy(x => x.Date));
                    }));
        private RelayCommand changeActivityCommand;

        public RelayCommand ChangeActivityCommand => this.changeActivityCommand ??
                    (this.changeActivityCommand = new RelayCommand(obj =>
                    {
                        if (ViewModel.ActivityNoteViewModel.SelectedActivityNote != null)
                        {
                            var note = ViewModel.ActivityNoteViewModel.SelectedActivityNote;
                            ActivityNoteDB.UpdateNote(note.Id, note.Date, note.Location, note.Hours, note.Minutes, note.Comment, note.Rating);
                        }
                    }));

        ActivityNote _selectedActivityNote;

        public ActivityNote SelectedActivityNote {
            get {
                return _selectedActivityNote;
            }

            set {
                _selectedActivityNote = value;
                OnPropertyChanged("SelectedActivityNote");
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
