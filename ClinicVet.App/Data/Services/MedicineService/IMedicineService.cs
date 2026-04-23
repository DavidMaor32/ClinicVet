using ClinicVet.Models;

namespace ClinicVet.App.Data.Services.MedicineService;

public interface IMedicineService
{
    Task<List<Medicine>> GetAllAsync();
    Task<Medicine> GetByIdAsync(int id);
    Task<Medicine> AddAsync(Medicine medicine);
    Task<Medicine> DeleteAsync(int id);
    Task<Medicine> AddQuantityAsync(int  id, int quantity);
    Task<Medicine> SubtractQuantityAsync(int id,  int quantity);
}