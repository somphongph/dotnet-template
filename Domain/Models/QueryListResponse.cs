namespace Domain.Models
{
    public class QueryListResponse<T> : BaseQueryResponse
    {
        public IEnumerable<T>? Data { get; set; }
        public int Total { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}