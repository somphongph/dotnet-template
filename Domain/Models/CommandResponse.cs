namespace Domain.Models
{
    public class CommandResponse<T> : BaseCommandResponse
    {
        public T? Data { get; set; }
    }
}