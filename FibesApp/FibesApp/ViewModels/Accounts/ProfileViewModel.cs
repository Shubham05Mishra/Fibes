using FibesApp.Views.Accounts;
using System;
using System.Collections.Generic;
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
