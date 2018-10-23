using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
    }
}