﻿using FibesApp.ViewModels.Accounts;
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
            // iOS Platform
            Xamarin.Forms.MessagingCenter.Send<string>("", "RefreshStatusBar");
            ProfileVM = new ProfileViewModel(this.Navigation);
            this.BindingContext = ProfileVM;
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
            base.OnAppearing();
        }
        #endregion
    }
}