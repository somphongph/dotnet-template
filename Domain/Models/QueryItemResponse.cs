namespace Domain.Models
{
    public class QueryItemResponse<T> : BaseQueryResponse
    {
        public T? Data { get; set; }
    }
}