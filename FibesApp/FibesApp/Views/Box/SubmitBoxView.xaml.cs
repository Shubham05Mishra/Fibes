using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FibesApp.ViewModels.Box;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace FibesApp.Views.Box
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubmitBoxView : ContentPage
    {
        //TODO : To Define Local Class Level Variables...
        protected SubmitBoxViewModel SubmitBoxVM;
        //TODO : To Define cosntructor...
        #region Constructor
        public SubmitBoxView()
        {
            InitializeComponent();
            //To Change the color of Safearea in ios
            var safeAreaInset = On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();
            SubmitBoxVM = new SubmitBoxViewModel(this.Navigation);
            this.BindingContext = SubmitBoxVM;
        }
        #endregion

        #region Event Handler
        /// <summary>
        /// TODO:To define the page on appearing event...
        /// </summary>
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(5000);
            TransferDone.IsVisible = true;
            Transfer.IsVisible = false;
        }
        #endregion
    }
}