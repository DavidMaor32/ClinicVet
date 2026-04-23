using ClinicVet.App.Data.Models;

namespace ClinicVet.App.Data.Services.RoleService;

public interface IRoleService
{
    public Task<List<Role>> GetAllAsync();
    public Task<Role> AddAsync(Role role);
    public Task DeleteAsync(Role role);
}
