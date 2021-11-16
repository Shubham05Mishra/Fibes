using System;
using System.Collections.Generic;
using System.Text;
using FibesApp.Views.Home;
using Xamarin.Forms;

namespace FibesApp.ViewModels.Menu
{
    public class AppMenuViewModel : BaseViewModel
    {
        #region Constructor
        public AppMenuViewModel(INavigation nav)
        {
            Navigation = nav;
            HomeCommand = new Command(OnHomeAsync);
        }


        #endregion

        #region Properties

        #endregion

        #region Command
        public Command HomeCommand { get; }
        #endregion

        #region Methods
        /// <summary>
        /// TODO : To Open Home Page As Detailed Page...
        /// </summary>
        private async void OnHomeAsync(object obj)
        {
            App.AppMasterDetailPage.IsPresented = false;
            App.AppMasterDetailPage.Detail = new Xamarin.Forms.NavigationPage(new HomeView());
            App.Current.MainPage = App.AppMasterDetailPage;
            App.AppMasterDetailPage.IsPresented = false; 
        }
        #endregion
    }
}
