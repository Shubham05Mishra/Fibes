using FibesApp.Views.Accounts;
using System;
using FibesApp.Views.Accounts;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FibesApp.Views.Home;
using FibesApp.Views.Box;

namespace FibesApp
{
    public partial class App : Application
    {

        public static MasterDetailPage AppMasterDetailPage = new MasterDetailPage();

        public App()
        {
            InitializeComponent(); 
            MainPage = new NavigationPage (new SearchView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
