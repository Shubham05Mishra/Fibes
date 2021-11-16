using FibesApp.Views.Accounts;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FibesApp.ViewModels.Accounts
{
   public class ProfileViewModel : BaseViewModel
    {
        #region Constructor
        public ProfileViewModel(INavigation nav)
        {
            Navigation = nav;
            LogoutCommand = new Command(OnLogoutAsync);
        }

        #endregion

        #region Command 
        public Command LogoutCommand { get; }
        #endregion

        #region Method
        private async void OnLogoutAsync(object obj)
        {
          // UserDialog.Alert("you want to Logout", "", "Ok");
            App.Current.MainPage = new Views.Accounts.LoginView();


        }
        #endregion


    }
}
