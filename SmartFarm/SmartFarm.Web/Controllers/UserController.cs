using Microsoft.AspNetCore.Mvc;
using SmartFarm.Domain.User.Models;
using SmartFarm.Domain.User.Services;

namespace SmartFarm.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IFarmerService _farmerService;
    private readonly IManagerService _managerService;

    public UserController( IUserService userService, IFarmerService farmerService, IManagerService managerService)
    {
        _userService = userService;
        _farmerService = farmerService;
        _managerService = managerService;
    }
    
    [HttpPost]
    public User CreateUserAsync(User user)
    {
        var newUser = new User(user.FullName, user.Username, user.Password, user.PhoneNumber, user.Role);
        return newUser;
    }
    
    [HttpPost("farmer")]
    public async Task CreateFarmerAsync(Farmer farmer)
    {
        await _farmerService.CreateFarmerAsync(farmer);
    }
    
    [HttpPost("manager")]
    public async Task CreateManagerAsync(Manager manager)
    {
        await _managerService.CreateManagerAsync(manager);
    }
    
    [HttpGet("{userId}")]
    public async Task<User> GetUserByIdAsync(Guid userId)
    {
        return await _userService.GetUserByIdAsync(userId);
    }
    
    [HttpGet("partners")]
    public async Task<List<User>> GetAllUserPartnerAsync()
    {
        throw new NotImplementedException();
    }
    
    [HttpGet("farmers")]
    public async Task<User> GetAllUserFarmersAsync()
    {
        throw new NotImplementedException();
    }
}
    
    