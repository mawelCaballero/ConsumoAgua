using System.Threading.Tasks;

namespace ConsumoAguaShared.Services
{
    public interface IDialer
    {

        Task<bool> DialAsync(string number);

    }
}
