﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Paul_Lorenaa_Lab12.Data;

namespace Paul_Lorenaa_Lab12
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }
        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
        }
    }
}
