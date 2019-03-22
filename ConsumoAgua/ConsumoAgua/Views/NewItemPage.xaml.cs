using ConsumoAgua.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConsumoAgua.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewItemPage : ContentPage
    {
        public Consumption Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();

            Item = new Consumption
            {

                Description = "This is an item description."
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Item);
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}