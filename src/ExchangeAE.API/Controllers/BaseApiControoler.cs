using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExchangeAE.API.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class BaseApiController : ControllerBase
{
}