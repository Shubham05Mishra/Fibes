using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FibesApp.ViewModels.Box
{
    public class EmptyBoxViewModel : BaseViewModel
    {
        #region Constructor
        public EmptyBoxViewModel(INavigation nav)
        {
            Navigation = nav;
            BackToHomeCommand = new Command(BackToHomeAsync);
            OptionCommand = new Command(OptionAsync);

        }        
        #endregion

        #region Properties
        #endregion

        #region Commands
        public Command BackToHomeCommand { get; }
        public Command OptionCommand { get; }
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
        /// TODO:To Call The Option command ...
        /// </summary>
        private void OptionAsync(object obj)
        {
            //throw new NotImplementedException();
        }
        #endregion
    }
}
