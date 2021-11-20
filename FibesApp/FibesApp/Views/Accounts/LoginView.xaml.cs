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
            //To Change the color of Safearea in ios
            var safeAreaInset = On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();
            LoginVM = new LoginViewModel(this.Navigation);
            this.BindingContext = LoginVM;

            /// <summary>
            /// TODO:To Change Focus from EmailEntry to PasswordEntry...
            /// </summary>
            EmailEntry.Completed += (Object sender, EventArgs e) =>
            {
                PasswordEntry.Focus();
            };
        }
        #endregion

        #region EventHandler
        /// <summary>
        /// TODO:To define the page on appearing event...
        /// </summary>
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            LoginVM.IsPageEnable = true;
        }
    #endregion
}
}