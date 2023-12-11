using SmartFarm.Domain.User.Models;

namespace SmartFarm.Domain.User.Services;

public interface IFarmerService
{
    Task CreateFarmerAsync(Farmer farmer);
}