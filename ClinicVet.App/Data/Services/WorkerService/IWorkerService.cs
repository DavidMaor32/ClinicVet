using ClinicVet.App.Data.Models;
using ClinicVet.Models;

namespace ClinicVet.App.Data.Services.WorkerService;

public interface IWorkerService
{
    Task<List<Worker>> GetAllAsync();
    Task<Worker> GetByWorkerIdAsync(string workerId);
    Task<Worker> AddAsync(Worker worker);
    Task<Worker> LoginAsync(string username, string password);
}