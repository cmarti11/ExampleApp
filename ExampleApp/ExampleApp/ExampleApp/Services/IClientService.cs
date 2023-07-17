using ExampleApp.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExampleApp.Services
{
    public interface IClientService
    {
        Task<List<Client>> GetClients();
    }
}
