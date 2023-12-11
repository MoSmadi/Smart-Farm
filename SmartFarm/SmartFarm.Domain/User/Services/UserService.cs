using SmartFarm.Domain.User.Enums;

namespace SmartFarm.Domain.User.Services;

public class UserService : IUserService
{
    public async Task<Models.User> GetUserByIdAsync(Guid id)
    {
        var user = await GetUserFromDatabase(id);
        return user;
    }

    private async Task<Models.User> GetUserFromDatabase(Guid id)
    {
        var user = new Models.User("John Doe", "johnde", "aaaaa", "UserRole.Farmer", UserRole.Manager);
        return user;
    }
}