using ConsumoAgua.Models;

namespace ConsumoAgua.ViewModels
{
    public class ConsumptionDetailViewModel : BaseViewModel
    {
        public Consumption Item { get; set; }
        public ConsumptionDetailViewModel(Consumption item = null)
        {
            Title = item?.Date.ToString();
            Item = item;
        }
    }
}
