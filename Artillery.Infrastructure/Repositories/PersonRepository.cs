using Artillery.Domain.Entities;
using Artillery.Domain.Interfaces.Repositories;
using Artillery.Infrastructure.Context;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace Artillery.Infrastructure.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ArtilleryContext _context;

        public PersonRepository(IConfiguration configuration)
        {
            _context = new ArtilleryContext(configuration);
        }

        public async Task InsertAsync(Person person)
        {
            await _context.Person.InsertOneAsync(person);
        }
    }
}
