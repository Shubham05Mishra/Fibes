using FibesApp.ViewModels.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace FibesApp.Views.Accounts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfileView : ContentPage
    {  //TODO : To Define Local Class Level Variables...
        protected ProfileViewModel ProfileVM;

        #region Constructor
        public ProfileView()
        {
            InitializeComponent();
            //To Change the color of Safearea in ios
            var safeAreaInset = On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();
            ProfileVM = new ProfileViewModel(this.Navigation);
            this.BindingContext = ProfileVM;
        }
        #endregion

        #region Event Handler
        /// <summary>
        /// TODO:To define the page on appearing event...
        /// </summary>
        protected async override void OnAppearing()
        {                       
            base.OnAppearing();
            ProfileVM.IsPageEnable = true;
            //ProfileVM.SelectedLanguage.LanguageName = "English";
        }
        /// <summary>
        /// TODO : To define the picker for language selection...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Languages(object sender, EventArgs e)
        {
            SelectLanguage.Focus();
        }
        #endregion
    }
}