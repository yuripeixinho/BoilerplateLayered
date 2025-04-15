using Microsoft.AspNetCore.Mvc;
using TF.Manager.Interfaces.Manager;

namespace TF.WebApi.Controllers;


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
