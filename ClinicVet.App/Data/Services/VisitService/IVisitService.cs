using ClinicVet.Models;

namespace ClinicVet.App.Data.Services.VisitService;

public interface IVisitService
{
    Task<Visit> AddAsync(Visit visit);
    Task<List<Visit>> GetAllAsync(Predicate<Visit>? predicate);
    Task<decimal> CalcCost(int visitId);
    Task<DateOnly> LastVaccine(int animalId);
}