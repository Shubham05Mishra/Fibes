using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FibesApp.ViewModels.Home;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace FibesApp.Views.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeView : ContentPage
    {
        //To Declare Local Variables Here 
        protected HomeViewModel HomeVM;

        #region Constrctor
        public HomeView()
        {
            InitializeComponent();
            // iOS Platform
            var safeAreaInset = On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();
            HomeVM = new HomeViewModel(this.Navigation);
            this.BindingContext = HomeVM;
        }
        #endregion

        #region Event Handeler
        /// <summary>
        /// TODO : To Define the Page On appearing Event...
        /// </summary>
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            //await Task.Delay(10);
            //var appMainPageScreenWidth = App.Current.MainPage.Width;
            //HomeVM.ScreenItemWidth = (appMainPageScreenWidth - 53) / 2;
            HomeVM.MyCollectionAsync();
        }
        #endregion
    }
}