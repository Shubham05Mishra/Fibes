using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FibesApp.ViewModels.Accounts
{
   public class ForgotPasswordViewModel : BaseViewModel
    {
        //TODO : To Define Local Variables Here 

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
            await Navigation.PopModalAsync();

        }

        /// <summary>
        /// TODO:To Call The Reset button ...
        /// </summary>
        private void OnResetAsync(object obj)
        {
            if (!Validate())
            {
                return;
            }
        }
        #endregion

        #region Validations
        /// <summary>
        /// TODO : To Apply Sign In Validations...
        /// </summary>
        private bool Validate()
        {
            if (string.IsNullOrEmpty(Email))
            {
                UserDialogs.Instance.Alert("Please enter valid email.");
                return false;
            }
            UserDialogs.Instance.HideLoading();
            return true;

        }
        #endregion
    }
}
