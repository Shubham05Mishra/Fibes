using FibesApp.Models;
using FibesApp.Views.Accounts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace FibesApp.ViewModels.Accounts
{
   public class ProfileViewModel : BaseViewModel
    {
        //TODO : To Define Local Variables Here 

        #region Constructor
        public ProfileViewModel(INavigation nav)
        {
            Navigation = nav;
            LogoutCommand = new Command(OnLogoutAsync);

            #region Bind Static List
            Languages = new ObservableCollection<LanguageModel>()
            {
                new LanguageModel()
                {
                    LanguageName = "English"
                },
                new LanguageModel()
                {
                    LanguageName = "Hindi"
                },
                new LanguageModel()
                {
                    LanguageName = "German"
                },
                new LanguageModel()
                {
                    LanguageName = "French"
                },
                new LanguageModel()
                {
                    LanguageName = "Spanish"
                },
                new LanguageModel()
                {
                    LanguageName = "Chinese"
                },
                new LanguageModel()
                {
                    LanguageName = "Urdu"
                },
            };
            #endregion
        }
        #endregion

        #region Properties
        private bool _IsPageEnable = true;
        public bool IsPageEnable
        {
            get { return _IsPageEnable; }
            set
            {
                if (_IsPageEnable != value)
                {
                    _IsPageEnable = value;
                    OnPropertyChanged("IsPageEnable");
                }
            }
        }
        private ObservableCollection<LanguageModel> _Languages;
        public ObservableCollection<LanguageModel> Languages
        {
            get { return _Languages; }
            set
            {
                if (_Languages != value)
                {
                    _Languages = value;
                    OnPropertyChanged("Languages");
                }
            }
        }

        private LanguageModel _SelectedLanguage;
        public LanguageModel SelectedLanguage
        {
            get { return _SelectedLanguage; }
            set
            {
                if (_SelectedLanguage != value)
                {
                    _SelectedLanguage = value;
                    OnPropertyChanged("SelectedLanguage");
                }
            }
        }
        #endregion

        #region Commands 
        public Command LogoutCommand { get; }      
        #endregion

        #region Methods
        /// <summary>
        /// TODO : To Define Logout Button...
        /// </summary>
        private async void OnLogoutAsync(object obj)
        {
            if (Device.RuntimePlatform == Device.Android)
            { IsPageEnable = false; }
            var confirmed = await UserDialog.ConfirmAsync(" Are you sure you want to Logout" ,"Alert", "Yes","No");
            if (confirmed)
            {
                App.Current.MainPage = new Views.Accounts.LoginView();
            }
        }
        #endregion

        #region Validations
        #endregion
    }
}
