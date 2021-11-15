﻿using System;
using FibesApp.Views.Accounts;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FibesApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
