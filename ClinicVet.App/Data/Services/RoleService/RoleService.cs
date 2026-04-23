using ClinicVet.App.Data.Exceptions;
using ClinicVet.App.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicVet.App.Data.Services.RoleService;

public class RoleService(AppDbContext context) : IRoleService
{
    public Task<List<Role>> GetAllAsync()
    {
        return context.Roles.AsNoTracking().ToListAsync();
    }

    public async Task<Role> AddAsync(Role role)
    {
        bool exists = await context.Roles.AnyAsync(r => r.Name == role.Name);

        if (exists)
        {
            throw new AlreadyExistsException("Role", role.Name);
        }
        
        context.Roles.Add(role);
        await context.SaveChangesAsync();
        
        return role;
    }

    public Task DeleteAsync(Role role)
    {
        context.Roles.Remove(role);
        return context.SaveChangesAsync();
    }
}