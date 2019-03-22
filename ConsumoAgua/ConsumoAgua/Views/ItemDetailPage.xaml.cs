using ConsumoAgua.Models;
using ConsumoAgua.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConsumoAgua.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        ConsumptionDetailViewModel viewModel;

        public ItemDetailPage(ConsumptionDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Consumption
            {
                Date = new DateTime(2019, 08, 01),
                Description = "This is an item description.",
                CubicLiters = 408

            };

            viewModel = new ConsumptionDetailViewModel(item);
            BindingContext = viewModel;
        }
    }
}