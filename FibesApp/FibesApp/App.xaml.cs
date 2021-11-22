using FibesApp.Views.Accounts;
using System;
using FibesApp.Views.Accounts;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FibesApp.Views.Home;
using FibesApp.Views.Box;
using FibesApp.Views.Menu;

namespace FibesApp
{
    public partial class App : Application
    {

        public static MasterDetailPage AppMasterDetailPage = new MasterDetailPage();

        public App()
        {
            InitializeComponent();
            MainPage = new LoginView();

            MessagingCenter.Subscribe<string>("", "GoToHomePage", (sender) =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    try
                    {
                        App.AppMasterDetailPage.Master = new AppMenuView();
                        App.AppMasterDetailPage.Detail = new HomeView();
                        App.Current.MainPage = App.AppMasterDetailPage;
                    }
                    catch (Exception ex)
                    { }
                });
            });
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
