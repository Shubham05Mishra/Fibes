using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FibesApp.ViewModels.Box
{
    public class SubmitBoxViewModel : BaseViewModel
    {
        //TODO : To Declare Local Variables Here 

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
        /// TODO:Open Home Page...
        /// </summary>
        private void BackToHomeAsync(object obj)
        {
            App.Current.MainPage = new Views.Home.HomeView();
        }

        /// <summary>
        /// TODO:Cancel Button Tap Event...
        /// </summary>
        private async void CancelAsync(object obj)
        {
           await Navigation.PopModalAsync();
        }
        #endregion
    }
}
