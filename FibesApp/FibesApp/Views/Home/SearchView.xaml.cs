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
    public partial class SearchView : ContentPage
    {
        //TODO : To Define Local Class Level Variables...
        protected SearchViewModel SearchVM;

        //TODO : To Define cosntructor...
        #region Constructor
        public SearchView()
        {
            InitializeComponent();
            // iOS Platform  
            var safeAreaInset = On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();
            SearchVM = new SearchViewModel(this.Navigation);
            this.BindingContext = SearchVM;
        }
        #endregion
        #region EventHandler
        /// <summary>
        /// TODO:To define the page on appearing event...
        /// </summary>
        protected async override void OnAppearing()
        {   
            base.OnAppearing();
            await Task.Delay(10);
            var appMainPageScreenWidth = App.Current.MainPage.Width;
            SearchVM.ScreenItemWidth = (appMainPageScreenWidth - 65) / 2;
            SearchVM.GetLatestSearch();
            SearchVM.GetPopularProduct();
        }
        #endregion
    }
}