using System.Threading.Tasks;

namespace ExampleApp.Services
{
    public interface IAccountService
    {
        Task<bool> LoginAsync(string userName, string password);
    }
}
