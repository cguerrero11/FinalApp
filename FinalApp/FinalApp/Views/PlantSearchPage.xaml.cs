using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalApp.Models;
using FinalApp.Views;
using FinalApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlantSearchPage : ContentPage
    {
        PlantSearchViewModel _viewModel;
        public PlantSearchPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new PlantSearchViewModel();
        }
        
        protected async void Search(object sender, FocusEventArgs e)
        {
            //activiates async
            //make input.Text search for 
            //output.Text = input.Text;

            //PlantItem 
            listView.ItemsSource = await App.PlantItemManager.GetTasksAsync(input.Text);
                //listView.ItemsSource = await App.CatFactsManager.GetTasksAsync();
        }


    }
}