using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Versioning.Controllers
{
    //https://localhost:7177/api/QueryString?api-version=2

    [Route("api/QueryString")]
    [ApiController]
    public class QueryStringV2Controller : ControllerBase
    {
        [HttpGet]
        [ApiVersion("2.0")]
        public IActionResult Get()
        {
            return new OkObjectResult(" from v2 controller");
        }
    }
}
