using SmartFarm.Domain.User.Models;

namespace SmartFarm.Domain.User.Services;

public class FarmerService : IFarmerService
{
    public Task CreateFarmerAsync(Farmer farmer)
    {
        // get manager id from authenticated user (UserContext)
        // get manager partner ids from database
        // set manager ids to farmer
        var managerIds = new List<Guid>();
                
        var newFarmer = new Farmer(farmer.FullName, farmer.Username, farmer.Password, farmer.PhoneNumber, farmer.ManagerIds);
        return Task.CompletedTask;
        // create farmer in database
        
        // await _farmerRepository.CreateFarmerAsync(newFarmer);
    }
}