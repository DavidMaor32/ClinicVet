using ClinicVet.App.Data.Exceptions;
using ClinicVet.App.Data.Models;
using ClinicVet.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicVet.App.Data.Services.WorkerService;

public class WorkerService(AppDbContext context) : IWorkerService
{
    public Task<List<Worker>> GetAllAsync()
    {
        return context.Workers.AsNoTracking().ToListAsync();
    }

    public async Task<Worker> GetByWorkerIdAsync(string id)
    {
        var worker = await context
            .Workers
            .AsNoTracking()
            .FirstOrDefaultAsync(w => w.Id.Equals(id));

        if (worker == null)
        {
            throw new NotFoundException("Worker", id);
        }
        
        return worker!;
    }

    public async Task<Worker> AddAsync(Worker worker)
    {
        bool exists = await context.Workers.AnyAsync(w => w.Id == worker.Id);

        if (exists)
        {
            throw new AlreadyExistsException("Worker", worker.Id);
        }

        var entry = await context.Workers.AddAsync(worker);
        await context.SaveChangesAsync();

        return entry.Entity;
    }

    public async Task<Worker> LoginAsync(string username, string password)
    {
        bool exists = await context.Workers.AnyAsync(w => w.Username == username);

        return null;

    }
}