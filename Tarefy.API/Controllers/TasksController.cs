using Microsoft.AspNetCore.Mvc;
using Tarefy.Communication.Requests;
using Tarefy.Communication.Responses;

namespace Tarefy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseCreateTask), StatusCodes.Status200OK)]
        public IActionResult CreateTask([FromBody] RequestCreateTaskJson request)
        {
            return Ok(request);
        }
    }
}
