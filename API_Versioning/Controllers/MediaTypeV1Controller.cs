using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Versioning.Controllers
{

    //https://localhost:7177/api/MediaType
    //Accept: application/json;ver=1.0   //(it's in Header section )


    [Route("api/MediaType")]
    [ApiVersion("1.0")]
    [ApiController]
    public class MediaTypeV1Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult(" from v1 controller");
        }
    }
}
