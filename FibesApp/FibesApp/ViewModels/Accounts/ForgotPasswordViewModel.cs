using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace FibesApp.ViewModels.Accounts
{
   public class ForgotPasswordViewModel : BaseViewModel
    {
        //TODO : To Define Local Variables Here 
        private const string _emailRegex = @"^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$";

        #region Constructor
        public ForgotPasswordViewModel(INavigation nav)
        {
            Navigation = nav;
            ResetCommand = new Command(OnResetAsync);
            SignInCommand = new Command(OnSignInAsync);
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
        public Command SignInCommand { get; }
        public Command ResetCommand { get; }

        #endregion

        #region Methods
        /// <summary>
        /// TODO:To Call The SignIn Page  ...
        /// </summary>
        private async void OnSignInAsync(object obj)
        {
            if (Device.RuntimePlatform == Device.Android)
            { IsPageEnable = false; }
            await Navigation.PopModalAsync();
        }

        /// <summary>
        /// TODO:To Call The Reset button ...
        /// </summary>
        private async void OnResetAsync(object obj)
        {
            if (!ValidateEmail())
            {
                return; 
            }
            var confirmed = await UserDialog.ConfirmAsync("Please check your email for password reset.", "Success", "OK", "");
            if (confirmed)
            {
                await Navigation.PopModalAsync();
                UserDialog.HideLoading();
            }
        }
        #endregion

        #region Validations
        /// <summary>
        /// TODO : To Apply Sign In Validations...
        /// </summary>
        private bool ValidateEmail()
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
            return true;
        }
        #endregion
    }
}
