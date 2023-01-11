using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JwtAuthentication_In_ThreeTierArchitecture.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        // GET: api/<EmployeeController>
        [HttpGet("GetListById")]
        public async Task<ActionResult> GetListById()
        {
            return Ok();
        }
        [HttpGet("Get")]
        public IEnumerable<string> Get()
        {
            return new string[] { "Vinay", "Ravula" };
        }
    }
}
