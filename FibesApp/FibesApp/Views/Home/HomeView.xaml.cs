using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FibesApp.Models;
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
            HomeVM.IsPageEnable = true;
        }

        /// <summary>
        /// TODO : To Define the Like Item Button Tab Event...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void LikeTapped(object sender, EventArgs e)
        {
            var item = (sender as Grid).BindingContext as ItemModel;
            if (item != null)
            {
                foreach (var imageItem in HomeVM.BrowseItemsList)
                {
                    if (imageItem.Id == item.Id)
                    {
                        if (item.IsLike)
                        {
                            imageItem.IsLike = false;
                            imageItem.IsNotLike = true;
                        }
                        else
                        {
                            imageItem.IsLike = true;
                            imageItem.IsNotLike = false;
                        }
                    }
                }
                LvBrowse.ItemsSource = null;
                LvBrowse.ItemsSource = HomeVM.BrowseItemsList;
            }
        }
        #endregion
    }
}