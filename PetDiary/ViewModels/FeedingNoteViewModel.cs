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
    public class FeedingNoteViewModel : ViewModelBase
    {
        public ObservableCollection<FeedingNote> FeedingNotes {
            get => _feedingNotes;
            set {
                _feedingNotes = value;
                OnPropertyChanged(nameof(FeedingNotes));
            }
        }

        FeedingNote _selectedFeedingNote;
        public FeedingNote SelectedFeedingNote {
            get {
                return _selectedFeedingNote;
            }
            set {
                _selectedFeedingNote = value;
                OnPropertyChanged("SelectedFeedingNote");
            }
        }
        public FeedingNoteViewModel()
        {
            FeedingNotes = new ObservableCollection<FeedingNote>();
        }

        private ObservableCollection<FeedingNote> _feedingNotes;
        private readonly FeedingNoteDB _feedingDB = new FeedingNoteDB();
        #region Commands

        private RelayCommand _addFeedingNoteCommand;
        public RelayCommand AddFeedingCommand {
            get {
                return _addFeedingNoteCommand ??
                  (_addFeedingNoteCommand = new RelayCommand(obj =>
                  {
                      var note = ViewModel.ReportFeedingViewModel.FeedingNote;
                      FeedingNoteDB.AddNote(note.Date, note.WetFood, note.DryFood, note.Meat, note.Medicines, note.Other, ViewModel.MainWindowViewModel.SelectedPet.Id);
                      if (ViewModel.MainWindowViewModel.SelectedPet != null)
                      {
                          GetPetFeedingNotes(ViewModel.MainWindowViewModel.SelectedPet.Id);
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

        private RelayCommand _deleteFeedingNoteCommand;
        public RelayCommand DeleteFeedingNoteCommand {
            get {
                return _deleteFeedingNoteCommand ??
                  (_deleteFeedingNoteCommand = new RelayCommand(obj =>
                  {
                      if (SelectedFeedingNote != null)
                      {
                          FeedingNoteDB.DeleteNoteById(SelectedFeedingNote.Id);
                          FeedingNotes.Remove(SelectedFeedingNote);
                          SelectedFeedingNote = FeedingNotes.FirstOrDefault();
                      }
                  }));
            }
        }
        private RelayCommand sortFeedingCommand;

        public RelayCommand SortFeedingCommand => this.sortFeedingCommand ??
                    (this.sortFeedingCommand = new RelayCommand(obj =>
                    {
                        FeedingNotes = new ObservableCollection<FeedingNote>(this.FeedingNotes.OrderBy(x => x.Date));

                    }));

        private RelayCommand changeFeedingCommand;
        public RelayCommand ChangeFeedingCommand => this.changeFeedingCommand ??
            (this.changeFeedingCommand = new RelayCommand(obj =>
            {
                if (ViewModel.FeedingNoteViewModel.SelectedFeedingNote != null)
                {
                    var note = ViewModel.FeedingNoteViewModel.SelectedFeedingNote;
                    FeedingNoteDB.UpdateNote(note.Id, note.Date, note.WetFood, note.DryFood, note.Meat, note.Medicines, note.Other);
                }
            }
            ));
        #endregion
        #region Methods
        public void GetPetFeedingNotes(int petId)
        {
            FeedingNotes.Clear();
            var items = _feedingDB.GetNotesByPetId(petId);
            items.ForEach(FeedingNotes.Add);
        }
        #endregion

    }
}
