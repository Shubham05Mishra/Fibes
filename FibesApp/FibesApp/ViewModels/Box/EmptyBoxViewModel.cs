using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FibesApp.ViewModels.Box
{
    public class EmptyBoxViewModel : BaseViewModel
    {
        //TODO : To Define Local Variables Here 

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
        /// TODO:Open Home Page...
        /// </summary>
        private void BackToHomeAsync(object obj)
        {
            App.Current.MainPage = new Views.Home.HomeView();
        }

        /// <summary>
        /// TODO:Open Options of Page...
        /// </summary>
        private void OptionAsync(object obj)
        {
            //throw new NotImplementedException();
        }
        #endregion
    }
}
