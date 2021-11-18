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
<<<<<<< HEAD
            InitializeComponent();

            MainPage = new NavigationPage (new ForgotPasswordView());
=======
            InitializeComponent(); 
            MainPage = new NavigationPage (new LoginView());
>>>>>>> a1667ecf229656efa478f5cce7f4cb93f357508e
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
