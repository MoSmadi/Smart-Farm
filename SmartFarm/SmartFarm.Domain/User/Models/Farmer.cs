using SmartFarm.Domain.User.Enums;

namespace SmartFarm.Domain.User.Models;

public class Farmer : User
{
    public List<Guid> ManagerIds { get; private set; }

    public Farmer(string fullName, string username, string password, string phoneNumber, List<Guid> managerIds) 
        : base(fullName, username, password, phoneNumber, UserRole.Farmer)
    {
        ManagerIds = managerIds;
    }
}