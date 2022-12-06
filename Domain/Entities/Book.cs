namespace Domain.Entities
{
    public class Book : BaseEntity
    {
        public string Name { get; set; } = String.Empty;
        public string Title { get; set; } = String.Empty;
    }
}