using FibesApp.Views.Accounts;
using System;
using FibesApp.Views.Accounts;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FibesApp.Views.Home;

namespace FibesApp
{
    public partial class App : Application
    {

        public static MasterDetailPage AppMasterDetailPage = new MasterDetailPage();

        public App()
        {
            InitializeComponent(); 
            MainPage = new NavigationPage (new HomeView());
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
