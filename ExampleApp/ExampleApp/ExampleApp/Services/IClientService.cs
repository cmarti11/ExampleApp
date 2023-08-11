using ExampleApp.Data.Dto;
using ExampleApp.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExampleApp.Services
{
    public interface IClientService
    {
        Task<List<Client>> GetClients();
        Task<ClientDetailDto> GetClient(long clientId);
    }
}
