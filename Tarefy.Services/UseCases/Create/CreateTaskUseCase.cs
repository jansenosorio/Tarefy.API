using Tarefy.Communication.Requests;
using Tarefy.Communication.Responses;

namespace Tarefy.Services.UseCases.Create
{
    public class CreateTaskUseCase
    {
        public ResponseCreateTask Execute(RequestCreateTaskJson request)
        {
            var response = new ResponseCreateTask();
            {
                response.Id = 1;
                response.Name = request.Name;
                response.Description = request.Description;
                response.Priority = request.Priority;
                response.DataLimite = request.DataLimite;
                response.Status = request.Status;
            }

            return response;
        }
    }
}
