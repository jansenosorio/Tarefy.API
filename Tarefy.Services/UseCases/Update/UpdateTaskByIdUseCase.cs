using Tarefy.Communication.Requests;
using Tarefy.Communication.Responses;

namespace Tarefy.Services.UseCases.Update
{
    public class UpdateTaskByIdUseCase
    {
        public ResponseCreateTask Execute(RequestUpdateTaskByIdJson request)
        {
            if (request.Id == 9999)
            {
                return null;
            }
            var response = new ResponseCreateTask
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description,
                Priority = request.Priority,
                DataLimite = request.DataLimite,
                Status = request.Status
            };
            return response;
        }
    }
}
