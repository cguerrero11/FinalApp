using System.ComponentModel;
using Xamarin.Forms;
using FinalApp.ViewModels;

namespace FinalApp.Views
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