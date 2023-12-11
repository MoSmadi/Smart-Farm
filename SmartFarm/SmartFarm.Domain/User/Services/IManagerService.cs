using SmartFarm.Domain.User.Models;

namespace SmartFarm.Domain.User.Services;

public interface IManagerService
{
    Task CreateManagerAsync(Manager manager);
}