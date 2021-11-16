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
            backCommand = new Command(OnbackAsync);
        }

        

        #endregion

        #region Command 
        public Command LogoutCommand { get; }
        public Command backCommand { get; }


        #endregion

        #region Method
        /// <summary>
        /// TODO : Logout
        /// </summary>
        private async void OnLogoutAsync(object obj)
        {
            var confirmed = await UserDialog.ConfirmAsync(" Are you sure you want to Logout" ,"Alert", "Yes","No");
            if (confirmed)
            {
                App.Current.MainPage = new Views.Accounts.LoginView();
            }
            return;
            

        }
        /// <summary>
        /// TODO : Back the Previous Page
        /// </summary>
        private async void OnbackAsync(object obj)
        {
            await Navigation.PopAsync();
        }
        #endregion


    }
}
