using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace ConsumoAgua.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Acerca de";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("http://mawel.name")));
        }

        public ICommand OpenWebCommand { get; }
    }
}