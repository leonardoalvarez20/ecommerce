using Microsoft.AspNetCore.Mvc;

using Modules.Users.Application.Interfaces;
using Modules.Users.Domain.Entities;

using Swashbuckle.AspNetCore.Annotations;


namespace Modules.Users.Endpoints;
public class UsersController : BaseV1Controller
{
    private readonly IUsersService _usersService;

    public UsersController(IUsersService usersService)
    {
        _usersService = usersService;
    }

    [HttpGet("{id}")]
    [Produces(contentType: "application/json")]
    [SwaggerResponse(statusCode: StatusCodes.Status200OK, description: "Return User data by User ID.", typeof(User))]
    public async Task<IActionResult> GetByIdAsync(string id)
    {
        var user = await _usersService.GetByIdAsync(id);
        if (user == null) return NotFound();
        return Ok(user);
    }
}