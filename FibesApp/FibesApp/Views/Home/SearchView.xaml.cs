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
    public partial class SearchView : ContentPage
    {
        //TODO : To Define Local Class Level Variables...
        protected SearchViewModel SearchVM;

        //TODO : To Define Constructor...
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
            SearchVM.IsPageEnable = true;
            SearchVM.GetLatestSearch();
            SearchVM.GetPopularProduct();
        }

        /// <summary>
        /// TODO:To define the search of Name based on firstname
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBar(object sender, TextChangedEventArgs e)
        {
            FilterName();
        }

        /// <summary>
        /// TODO : To define FilterName method
        /// </summary>
        private void FilterName()
        {
            try
            {
                var tempList = new List<LatestSearchItemModel>();
                string filterserch = SearchString.Text.ToLower().TrimStart().TrimEnd();
                tempList = SearchVM.LatestSearchList.Where(x => x.SearchItem.ToLower().Contains(filterserch)).ToList();
                LatestSearchList.ItemsSource = tempList;
                if (tempList.Count == 0)
                {
                    SearchVM.IsLatestSearchListVisible = false;
                    SearchVM.IsEmptyListVisible = true;
                }
                else
                {
                    SearchVM.IsLatestSearchListVisible = true;
                    SearchVM.IsEmptyListVisible = false;
                }
            }
            catch (Exception ex)
            {
                var x = ex.Message;
            }
        }
        #endregion
    }
}