using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Acr.UserDialogs;
using FibesApp.Views.Home;
using FibesApp.Views.Menu;
using Xamarin.Forms;

namespace FibesApp.ViewModels.Accounts
{
    public class LoginViewModel : BaseViewModel
    {
        private const string _password = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
        private const string _emailRegex = @"^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$";
        #region Constructor
        public LoginViewModel(INavigation nav)
        {
            Navigation = nav;
            SignInCommand = new Command(OnSignInAsync);
            ForgotPasswordCommand = new Command(OnForgotPasswordAsync);
        }


        #endregion

        #region Properties
        private string _Email;
        public string Email
        {
            get { return _Email; }
            set
            {
                if (_Email != value)
                {
                    _Email = value;
                    OnPropertyChanged("Email");
                }
            }
        }
        private string _Password;
        public string Password
        {
            get { return _Password; }
            set
            {
                if (_Password != value)
                {
                    _Password = value;
                    OnPropertyChanged("Password");
                }
            }
        }
        #endregion

        #region Command
        public Command SignInCommand { get; }
        public Command ForgotPasswordCommand { get; }
        #endregion

        #region Methods
        /// <summary>
        /// TODO:To Call The SignIn button ...
        /// </summary>
        private async void OnSignInAsync(object obj)
        {
            if (!ValidateSignIn())
            {
                return;
            }
            App.AppMasterDetailPage.Master = new AppMenuView();
            App.AppMasterDetailPage.Detail = new HomeView();
            App.Current.MainPage = App.AppMasterDetailPage;
        }
        /// <summary>
        /// TODO:To Call The ForgotPassword Command ...
        /// </summary>
        private async void OnForgotPasswordAsync(object obj)
        {
            await Navigation.PushAsync(new Views.Accounts.ForgotPasswordView());
        }
        #endregion

        #region Validations
        /// <summary>
        /// TODO : To Apply Sign In Validations...
        /// </summary>
        private bool ValidateSignIn()
        {
            if (string.IsNullOrEmpty(Email))
            {
                UserDialogs.Instance.Alert("Please enter email.");
                return false;
            }
            bool isValid = (Regex.IsMatch(Email, _emailRegex, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)));
            if (!isValid)
            {
                UserDialogs.Instance.Alert("Please enter valid email address.");
                return false;
            }
            if (string.IsNullOrEmpty(Password))
            {
                UserDialogs.Instance.Alert("Please enter password.");
                return false;
            }
            bool isValid1 = (Regex.IsMatch(Password, _password, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)));
            if (!isValid1)
            {
                UserDialogs.Instance.Alert("Please enter valid password.");
                return false;
            }
            UserDialogs.Instance.HideLoading();
            return true;
        }
        #endregion
    }
}
