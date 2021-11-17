using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FibesApp.ViewModels.Box
{
    public class SubmitBoxViewModel : BaseViewModel
    {
        #region Constructor
        public SubmitBoxViewModel(INavigation nav)
        {
            Navigation = nav;
            CancelCommand = new Command(CancelAsync);
            BackToHomeCommand = new Command(BackToHomeAsync);            
        }       
        #endregion

        #region Properties
        #endregion

        #region Commands
        public Command CancelCommand { get; }
        public Command BackToHomeCommand { get; }       
        #endregion

        #region Methods
        /// <summary>
        /// TODO:To Call The BackToHome button ...
        /// </summary>
        private void BackToHomeAsync(object obj)
        {
            App.Current.MainPage = new Views.Home.HomeView();
        }

        /// <summary>
        /// TODO:To Call The Cancel command ...
        /// </summary>
        private void CancelAsync(object obj)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
