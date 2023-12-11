using SmartFarm.Domain.User.Enums;

namespace SmartFarm.Domain.User.Models;

public class Manager : User
{
    public List<Farmer>? Farmers { get; private set; }
    
    public List<Guid>? Partners { get; private set; }
    
    public Manager(string fullName, string username, string password, string phoneNumber) 
        : base(fullName, username, password, phoneNumber, UserRole.Manager)
    {
    }
}