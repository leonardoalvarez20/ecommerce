using Asp.Versioning;

using Microsoft.AspNetCore.Mvc;

namespace Modules.Users.Endpoints;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class BaseV1Controller : ControllerBase
{

}