using Artillery.Domain.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace Artillery.Infrastructure.Context
{
    public class ArtilleryContext
    {
        private readonly IMongoDatabase _mongoDatabase;
        public ArtilleryContext(IConfiguration configuration)
        {
            var conventionPack = new ConventionPack { new CamelCaseElementNameConvention() };
            ConventionRegistry.Register("camelCase", conventionPack, t => true);

            var client = new MongoClient(configuration.GetSection("ConnectionString").Value);
            _mongoDatabase = client.GetDatabase(configuration.GetSection("Database").Value);
        }

        public IMongoCollection<Person> Person =>
            _mongoDatabase.GetCollection<Person>("Person");

    }
}
