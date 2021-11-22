using System;
using System.Collections.Generic;
using System.Text;
using FibesApp.Views.Home;
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
        /// TODO: To Open Home Page...
        /// </summary>
        private void BackToHomeAsync(object obj)
        {
            App.AppMasterDetailPage = new MasterDetailPage();
            App.AppMasterDetailPage.Master = new Views.Menu.AppMenuView();
            App.AppMasterDetailPage.Detail = new HomeView();
            App.Current.MainPage = App.AppMasterDetailPage;
        }

        /// <summary>
        /// TODO:To Open Options of Page...
        /// </summary>
        private void OptionAsync(object obj)
        {
            
        }
        #endregion

        #region Validations
        #endregion
    }
}
