using DiabetesDoctorApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DiabetesDoctorApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}