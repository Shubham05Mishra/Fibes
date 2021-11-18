﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FibesApp.Models;
using FibesApp.ViewModels.Menu;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace FibesApp.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailView : ContentPage
    {
        //TODO : To Declare Local Variables Here 
        protected ItemDetailViewModel ItemDetailVM;

        #region Constructor
        public ItemDetailView()
        {
            InitializeComponent();
            //To Change the color of Safearea in ios
            var safeAreaInset = On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();
            ItemDetailVM = new ItemDetailViewModel(this.Navigation);
            this.BindingContext = ItemDetailVM;
        }
        #endregion

        #region Event Handler
        /// <summary>
        /// TODO : To Define the Page On appearing Event...
        /// </summary>
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            ItemDetailVM.OverViewAsync();
        }
        #endregion
    }
}