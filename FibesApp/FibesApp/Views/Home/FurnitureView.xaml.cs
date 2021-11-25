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
	public partial class FurnitureView : ContentPage
    {
        //TODO : To Define Local Class Level Variables...
        protected FurnitureViewModel FurnitureVM;

        //TODO : To Define Constructor...
        #region Constructor
        public FurnitureView()
        {
            InitializeComponent();
            // iOS Platform  
            var safeAreaInset = On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();
            FurnitureVM = new FurnitureViewModel(this.Navigation);
            this.BindingContext = FurnitureVM;            
        }
        #endregion

        #region EventHandler
        /// <summary>
        /// TODO:To define the page on appearing event...
        /// </summary>
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            FurnitureVM.GetFurnitureItem();
        }
        #endregion
    }
}