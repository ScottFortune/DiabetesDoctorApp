using DiabetesDoctorApp.ViewModels;
using DiabetesDoctorApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace DiabetesDoctorApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(Diabetes101Page), typeof(Diabetes101Page));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
