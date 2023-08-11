using ExampleApp.Data.Dto;
using ExampleApp.Data.Models;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExampleApp.Data.API
{
    public interface IClientApi
    {
        [Get("/Clients")]
        Task<IEnumerable<Client>> GetClients();

        [Get("/Clients/{id}")]
        Task<ClientDetailDto> GetClient(long id);
    }
}
