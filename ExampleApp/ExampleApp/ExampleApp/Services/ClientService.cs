using ExampleApp.Data.API;
using ExampleApp.Data.Dto;
using ExampleApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleApp.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientApi _clientApi;

        public ClientService(IClientApi clientApi)
        {
            _clientApi = clientApi;
        }

        public async Task<ClientDetailDto> GetClient(long clientId)
        {
            var client = new ClientDetailDto();

            try
            {
                client = await _clientApi.GetClient(clientId);
                return client;
            }
            catch (Exception ex)
            {
                var error = ex.Message;
            }
            return client;
        }
    
        public async Task<List<Client>> GetClients()
        {
            var clients = new List<Client>();

            try
            {
                var response = await _clientApi.GetClients();
                clients = response.ToList();
                return clients;
            }
            catch (Exception ex)
            {
                var error = ex.Message;
            }
            return clients;
        }
    }
}
