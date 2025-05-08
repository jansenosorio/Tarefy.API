using Tarefy.Communication.Responses;
using Tarefy.Communication.Enums;

namespace Tarefy.Services.UseCases.Get
{
    public class GetAllTasksUseCase
    {
        public List<ResponseCreateTask> Execute()
        {
            var response = new List<ResponseCreateTask>();
            {
                for (int i = 0; i < 10; i++)
                {
                    response.Add(new ResponseCreateTask
                    {
                        Id = i,
                        Name = $"Task {i}",
                        Description = $"Description {i}",
                        Priority = TaskPriorityType.Baixa,
                        DataLimite = DateTime.Now.AddDays(i),
                        Status = TaskStatusType.Aguardando
                    });
                }
            }
            return response;
        }
    }
}
