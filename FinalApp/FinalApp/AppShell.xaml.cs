using System;
using System.Collections.Generic;
using FinalApp.ViewModels;
using FinalApp.Views;
using Xamarin.Forms;

namespace FinalApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
