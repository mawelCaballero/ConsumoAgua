using ConsumoAgua.UWP;
using ConsumoAguaShared.Services;
using System.Threading.Tasks;
using Windows.Foundation.Metadata;
using Xamarin.Forms;

[assembly: Dependency(typeof(PhoneDialer))]
namespace ConsumoAgua.UWP
{
    public class PhoneDialer : IDialer
    {
        public Task<bool> DialAsync(string number)
        {
            if (ApiInformation.IsApiContractPresent("Windows.ApplicationModel.Calls.CallsPhoneContract", 1, 0))
            {
                //     PhoneCallManager.ShowPhoneCallUI(number, "Phoneword");

                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }
    }
}
