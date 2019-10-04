using System.Threading.Tasks;
using Artillery.Domain.Entities;
using Artillery.Domain.Interfaces.Entities;
using Artillery.Domain.Interfaces.Repositories;

namespace Artillery.Domain.Services
{
    public class PersonDomainService : IPersonDomainService
    {
        private readonly IPersonRepository _personRepository;
        public PersonDomainService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<Person> InsertAsync(Person person)
        {
            person.CalculateAge();
            await _personRepository.InsertAsync(person);

            return person;
        }
    }
}
