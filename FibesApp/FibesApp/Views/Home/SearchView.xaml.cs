using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FibesApp.ViewModels.Home;
using Xamarin.Forms;
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
            Xamarin.Forms.MessagingCenter.Send<string>("", "RefreshStatusBar");
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
            //To Change the color of Safearea in ios
            //var safeAreaInset = On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();
            //BgStack.Padding = safeAreaInset;
            //To change the color of every page in status bar
            Xamarin.Forms.MessagingCenter.Send<string>("", "RefreshStatusBar");            
            base.OnAppearing();
            SearchVM.GetLatestSearch();
            SearchVM.GetPopularProduct();
        }
        #endregion
    }
}