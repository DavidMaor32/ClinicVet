using ClinicVet.App.Data.Exceptions;
using ClinicVet.App.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicVet.App.Data.Services.AnimalTypeService;

public class AnimalTypeService(AppDbContext context) : IAnimalTypeService
{
    public Task<List<AnimalType>> GetAllAsync()
    {
        return context.AnimalTypes.AsNoTracking().ToListAsync();
    }

    public async Task<AnimalType> AddAsync(AnimalType animalType)
    {
        bool exists = await context.AnimalTypes.AnyAsync(r => r.Name == animalType.Name);

        if (exists)
        {
            throw new AlreadyExistsException("Animal Type", animalType.Name);
        }
        
        context.AnimalTypes.Add(animalType);
        await context.SaveChangesAsync();
        
        return animalType;
    }

    public Task DeleteAsync(AnimalType animalType)
    {
        context.AnimalTypes.Remove(animalType);
        return context.SaveChangesAsync();
    }
}