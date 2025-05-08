using Tarefy.Communication.Enums;

namespace Tarefy.Communication.Responses
{
    public class ResponseCreateTask

    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public TaskPriorityType Priority { get; set; } = TaskPriorityType.Baixa;
        public DateTime DataLimite { get; set; }
        public TaskStatusType Status { get; set; } = TaskStatusType.Aguardando;
    }
}
