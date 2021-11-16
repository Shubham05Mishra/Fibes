using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FibesApp.ViewModels.Accounts;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace FibesApp.Views.Accounts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        //TODO : To Define Local Class Level Variables...
        protected LoginViewModel LoginVM;

        //TODO : To Define cosntructor...
        #region Constructor
        public LoginView()
        {
            InitializeComponent();
            // iOS Platform
            Xamarin.Forms.MessagingCenter.Send<string>("", "RefreshStatusBar");
            LoginVM = new LoginViewModel(this.Navigation);
            this.BindingContext = LoginVM;
        }
        #endregion

        #region EventHandler
        /// <summary>
        /// TODO:To define the page on appearing event...
        /// </summary>
        protected async override void OnAppearing()
        {
            //To Change the color of Safearea in ios
            var safeAreaInset = On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();
            BgStack.Padding = safeAreaInset;
            //To change the color of every page in status bar
            Xamarin.Forms.MessagingCenter.Send<string>("", "RefreshStatusBar");
            //To Focous on firstentry of Signupup
            await Task.Delay(1);            
            base.OnAppearing();
        }
        #endregion
    }
}