using Microsoft.AspNetCore.Mvc;
using VT.Manager.Interfaces.Manager;

namespace VT.WebApi.Controllers;


public class UserController: ApiControllerBase
{
    private readonly IUserManager _userManager;

    public UserController(IUserManager userManager)
    {
        _userManager = userManager; 
    }

    [HttpGet]
    [Route("/users")]
    public async Task<IActionResult> GetAllUsers()
    {
        return Ok(await _userManager.GetUsersAsync()); 
    }
 }
