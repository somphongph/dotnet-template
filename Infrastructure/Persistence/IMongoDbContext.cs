using MongoDB.Driver;

namespace Infrastructure.Persistence
{
    public interface IMongoDbContext
    {
        IMongoCollection<TDocument> GetCollection<TDocument>(string name);
    }
}