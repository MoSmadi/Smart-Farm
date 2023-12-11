namespace SmartFarm.Domain.User.Services;

public interface IUserService
{
    public Task<Models.User> GetUserByIdAsync(Guid id);
}