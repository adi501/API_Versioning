using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Versioning.Controllers
{

    //'https://localhost:7177/api/Header_Based' \
    //-H 'X-Version: 1'  (it's in Header section )
    [Route("api/Header_Based")]
    [ApiVersion("1.0")]
    [ApiController]
    public class Header_BasedV1Controller : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult(" from v1 controller");
        }
    }
}
