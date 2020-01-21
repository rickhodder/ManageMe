using Microsoft.AspNetCore.Mvc;

namespace ManageMe.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : Controller
    {
    }
}
