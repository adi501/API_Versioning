using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Versioning.Controllers
{
    //https://localhost:7177/api/2/URL_Based

    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/{v:apiVersion}/URL_Based")]
    public class URL_BasedV2Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult(" from v2 controller");
        }
    }
}
