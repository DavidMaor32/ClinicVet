using ClinicVet.Models;

namespace ClinicVet.App.Data.Services.ClientService;

public interface IClientService
{
    Task<List<Client>> GetAllAsync();
    Task<Client> GetByIdAsync(int id);
    Task<Client> AddAsync(Client client);
    Task<List<Client>> SearchAsync(string searchTerm);
    Task<Client> DeleteAsync(int id);
}