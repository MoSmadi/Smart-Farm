using SmartFarm.Domain.User.Enums;

namespace SmartFarm.Domain.User.Models;

public class User
{
    public Guid UserId { get; private set; }
    public string FullName { get; private set; }
    public string Username { get; private set; }
    public string Password { get; private set; }
    public string PhoneNumber { get; private set; }
    public string? Email { get; private set; }
    public DateTime? Birthday { get; private set; }
    public UserRole Role { get; private set; }

    public User(string fullName, string username, string password, string phoneNumber, UserRole role)
    {
        FullName = fullName;
        Username = username;
        Password = password;
        PhoneNumber = phoneNumber;
        Role = role;
    }
}