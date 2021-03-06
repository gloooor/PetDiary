﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDiary.ViewModels
{
    public class ApplicationContext
    {
        public UserViewModel UserViewModel { get; set; }
        public PetViewModel PetViewModel { get; set; }
        public ActivityNoteViewModel ActivityNoteViewModel { get; set; }
        public FeedingNoteViewModel FeedingNoteViewModel { get; set; }
        public AddPetViewModel AddPetViewModel { get; set; }
        public ReportActivityViewModel ReportActivityViewModel { get; set; }
        public ReportFeedingViewModel ReportFeedingViewModel { get; set; }
        public RegistrationViewModel RegistrationViewModel { get; set; }
        public StatViewModel StatViewModel { get; set; }
        public MainWindowViewModel MainWindowViewModel { get; set; }
        public ReportStatViewModel ReportStatViewModel { set; get; }
        public static ApplicationContext Get()
        {
            return new ApplicationContext
            {
                ActivityNoteViewModel = ViewModel.ActivityNoteViewModel,
                FeedingNoteViewModel = ViewModel.FeedingNoteViewModel,
                PetViewModel = ViewModel.PetViewModel,
                UserViewModel = ViewModel.UserViewModel,
                AddPetViewModel = ViewModel.AddPetViewModel,
                ReportActivityViewModel = ViewModel.ReportActivityViewModel,
                ReportFeedingViewModel = ViewModel.ReportFeedingViewModel,
                ReportStatViewModel = ViewModel.ReportStatViewModel,
                RegistrationViewModel = ViewModel.RegistrationViewModel,
                StatViewModel = ViewModel.StatViewModel,
                MainWindowViewModel = ViewModel.MainWindowViewModel,
            };
        }
    }

    public static class ViewModel
    {
        private static UserViewModel _userViewModel;
        private static PetViewModel _petViewModel;
        private static ActivityNoteViewModel _activityNoteViewModel;
        private static FeedingNoteViewModel _feedingNoteViewModel;
        private static AddPetViewModel _addPetViewModel;
        private static ReportActivityViewModel _addActivityViewModel;
        private static ReportFeedingViewModel _addFeedingViewModel;
        private static RegistrationViewModel _registrationViewModel;
        private static ReportStatViewModel _reportStatViewModel;
        private static StatViewModel _statViewModel;
        private static MainWindowViewModel _mainWindowViewModel;
        public static UserViewModel UserViewModel {
            get {
                return _userViewModel ?? (_userViewModel = new UserViewModel());
            }
        }
        public static PetViewModel PetViewModel {
            get {
                return _petViewModel ?? (_petViewModel = new PetViewModel());
            }
        }
        public static MainWindowViewModel MainWindowViewModel {
            get {
                return _mainWindowViewModel ?? (_mainWindowViewModel = new MainWindowViewModel());
            }
        }
        public static ActivityNoteViewModel ActivityNoteViewModel {
            get {
                return _activityNoteViewModel ?? (_activityNoteViewModel = new ActivityNoteViewModel());
            }
        }
        public static FeedingNoteViewModel FeedingNoteViewModel {
            get {
                return _feedingNoteViewModel ?? (_feedingNoteViewModel = new FeedingNoteViewModel());
            }
        }
        public static AddPetViewModel AddPetViewModel {
            get {
                return _addPetViewModel ?? (_addPetViewModel = new AddPetViewModel());
            }
        }
        public static ReportStatViewModel ReportStatViewModel {
            get {
                return _reportStatViewModel ?? (_reportStatViewModel = new ReportStatViewModel());
            }
        }
        public static StatViewModel StatViewModel {
            get {
                return _statViewModel ?? (_statViewModel = new StatViewModel());
            }
        }
        public static ReportActivityViewModel ReportActivityViewModel {
            get {
                return _addActivityViewModel ?? (_addActivityViewModel = new ReportActivityViewModel());
            }
        }
        public static ReportFeedingViewModel ReportFeedingViewModel {
            get {
                return _addFeedingViewModel ?? (_addFeedingViewModel = new ReportFeedingViewModel());
            }
        }
        public static RegistrationViewModel RegistrationViewModel {
            get {
                return _registrationViewModel ?? (_registrationViewModel = new RegistrationViewModel());
            }
        }
    }
}
