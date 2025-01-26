using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Versioning.Controllers
{
    //https://localhost:7177/api/QueryString?api-version=1
    //https://localhost:7177/api/QueryString

    [Route("api/QueryString")]
    [ApiController]
    public class QueryStringV1Controller : ControllerBase
    {
        [HttpGet]
        [ApiVersion("1.0")]
       
        public IActionResult Get()
        {
            return new OkObjectResult(" from v1 controller");
        }
    }
}
