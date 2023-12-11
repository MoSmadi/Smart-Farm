using SmartFarm.Domain.User.Models;

namespace SmartFarm.Domain.User.Services;

public class ManagerService : IManagerService
{
    public Task CreateManagerAsync(Manager manager)
    {
        // get manager partner ids from database
        // set manager ids to farmer
        var partnerIds = new List<Guid>();
                
        var newManager = new Manager(manager.FullName, manager.Username, manager.Password, manager.PhoneNumber);
        
        // create manager in database
        // await _managerRepository.CreateManagerAsync(newManager);
        
        // add this created manager id to all other partner
        // await _managerRepository.AddPartnerIdToManagersAsync(partnerIds, newManager.Id);
        
        // get manager farmer ids from database
        // set new manager id to farmers
        // await _managerRepository.AddManagerIdRoFarmersAsync(farmerIds, newManager.Id);
        return Task.CompletedTask;
    }
}