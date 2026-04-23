using ClinicVet.App.Data.Models;

namespace ClinicVet.App.Data.Services.AnimalService;

public interface IAnimalService
{
    Task<Animal> GetByIdAsync(int id);
    Task<List<Animal>> GetAllAsync();
    Task<Animal>  AddAsync(Animal animal);
    Task<List<Animal>> GetByOwnerIdAsync(int ownerId);
    Task<List<Animal>> SearchAsync(string searchTerm);
    Task<Animal> DeleteAsync(int id);
}