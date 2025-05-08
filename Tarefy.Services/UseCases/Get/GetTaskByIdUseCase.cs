using Tarefy.Communication.Enums;
using Tarefy.Communication.Responses;

namespace Tarefy.Services.UseCases.Get
{
    public class GetTaskByIdUseCase
    {
        public ResponseCreateTask Execute(int id)
        {
            if (id == 9999)
            {
                return null;
            }

            var response = new ResponseCreateTask();
            {
                response.Id = id;
                response.Name = $"Task {id}";
                response.Description = $"Description {id}";
                response.Priority = TaskPriorityType.Baixa;
                response.DataLimite = DateTime.Now.AddDays(id);
                response.Status = TaskStatusType.Aguardando;
            }
            return response;
        }
    }
}
