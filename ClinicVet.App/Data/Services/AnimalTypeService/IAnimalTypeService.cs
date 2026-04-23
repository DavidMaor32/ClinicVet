using ClinicVet.App.Data.Models;

namespace ClinicVet.App.Data.Services.AnimalTypeService;

public interface IAnimalTypeService
{
    Task<List<AnimalType>> GetAllAsync();
    Task<AnimalType> AddAsync(AnimalType animalType);
    Task DeleteAsync(AnimalType animalType);
}