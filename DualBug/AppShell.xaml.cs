using System;
using System.Collections.Generic;
using DualBug.ViewModels;
using DualBug.Views;
using Xamarin.Forms;

namespace DualBug
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
