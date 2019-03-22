using ConsumoAgua.Models;
using ConsumoAgua.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConsumoAgua.ViewModels
{
    public class ConsumptionViewModel : BaseViewModel
    {

        public ObservableCollection<Consumption> Consumptions { get; set; }
        public Command LoadConsumptionsCommand { get; set; }

        public ConsumptionViewModel()
        {
            Title = "Consumo Agua";
            Consumptions = new ObservableCollection<Consumption>();
            LoadConsumptionsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewItemPage, Consumption>(this, "AddItem", async (obj, item) =>
            {
                var newItem = item as Consumption;
                Consumptions.Add(newItem);
                await DataStore.AddItemAsync(newItem);
            });
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Consumptions.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Consumptions.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
