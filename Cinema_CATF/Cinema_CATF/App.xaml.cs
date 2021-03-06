﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Cinema_CATF
{

    public partial class App : Application

    {


        public App()
        {
            // Initialize Live Reload.
#if DEBUG
            LiveReload.Init();
#endif
            InitializeComponent();

            MainPage = new NavigationPage(new CarteleraPage());

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
