using FibesApp.Models;
using FibesApp.ViewModels.Box;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace FibesApp.Views.Box
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BoxDetailView : ContentPage
    {
        //TODO : To Define Local Class Level Variables
        protected BoxDetailViewModel BoxDetailVM;

        #region Constructor
        public BoxDetailView()
        {
            InitializeComponent();
            //To Change the color of Safearea in ios
            var safeAreaInset = On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();
            BoxDetailVM = new BoxDetailViewModel(this.Navigation);
            this.BindingContext = BoxDetailVM;
        }
        #endregion

        #region Event Handeler
        /// <summary>
        /// TODO : To Define the Page On appearing Event...
        /// </summary>
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            BoxDetailVM.IsPageEnable = true;           
        }
        #endregion
        /// <summary>
        /// TODO : To Increse quantity of items...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemIncrementButton(object sender, EventArgs e)
        {
            var item = (sender as Button).BindingContext as BoxDetailModel;
            if (item != null)
            {
                foreach (var ItemCount in BoxDetailVM.DetailItemsList)
                {
                    if (ItemCount.Id == item.Id)
                    {
                        item.ItemCount += 1;
                        break;
                    }
                }
            }
        }
        /// <summary>
        /// TODO : To Decrease quantity of items...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemDecrementCommand(object sender, EventArgs e)
        {
            var item = (sender as Button).BindingContext as BoxDetailModel;
            if (item != null)
            {
                foreach (var ItemCount in BoxDetailVM.DetailItemsList)
                {
                    if (ItemCount.Id == item.Id)
                    {
                        if (item.ItemCount > 1)
                        {
                            item.ItemCount -= 1;
                        }
                        break;
                    }
                }
            }
        }
    }
}