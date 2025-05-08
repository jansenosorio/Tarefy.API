using Microsoft.AspNetCore.Mvc;
using Tarefy.Communication.Requests;
using Tarefy.Communication.Responses;
using Tarefy.Services.UseCases.Create;

namespace Tarefy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseCreateTask), StatusCodes.Status201Created)]
        public IActionResult CreateTask([FromBody] RequestCreateTaskJson request)
        {
            var useCase = new CreateTaskUseCase();
            var response = useCase.Execute(request);
            return Ok(response);
        }
    }
}
