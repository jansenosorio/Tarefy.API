using Microsoft.AspNetCore.Mvc;
using Tarefy.Communication.Requests;
using Tarefy.Communication.Responses;
using Tarefy.Services.UseCases.Create;
using Tarefy.Services.UseCases.Get;

namespace Tarefy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseCreateTask), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreateTask([FromBody] RequestCreateTaskJson request)
        {
            var useCase = new CreateTaskUseCase();
            var response = useCase.Execute(request);
            return Ok(response);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ResponseCreateTask>), StatusCodes.Status200OK)]
        public IActionResult GetAllTasks()
        {
            var useCase = new GetAllTasksUseCase();
            var response = useCase.Execute();
            return Ok(response);
        }

        [HttpGet]
        [Route("{id:int}")]
        [ProducesResponseType(typeof(ResponseCreateTask), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetTaskById(int id)
        {
            var useCase = new GetTaskByIdUseCase();
            var response = useCase.Execute(id);

            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }
    }
}
