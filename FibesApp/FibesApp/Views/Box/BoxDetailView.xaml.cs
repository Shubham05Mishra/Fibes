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
           // BoxDetailVM.GetItems();
        }
        #endregion
    }
}