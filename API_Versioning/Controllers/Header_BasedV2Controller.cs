using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Versioning.Controllers
{

    //'https://localhost:7177/api/Header_Based' \
    //-H 'X-Version: 2'  (it's in Header section )
    [Route("api/Header_Based")]
    [ApiVersion("2.0")]
    [ApiController]
    public class Header_BasedV2Controller : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult(" from v2 controller");
        }
    }
}
