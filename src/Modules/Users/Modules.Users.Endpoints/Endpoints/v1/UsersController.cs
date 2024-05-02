using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

using Modules.Users.Application.Interfaces;


namespace Modules.Users.Endpoints;
public class UsersController: BaseV1Controller
{
    private readonly IUsersService _usersService;

    public UsersController(IUsersService usersService)
    {
        _usersService = usersService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(string id){
        var user = await _usersService.GetByIdAsync(id);
        if (user == null) return NotFound();
        return Ok(user);
    }
}
