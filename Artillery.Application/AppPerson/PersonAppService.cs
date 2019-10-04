using Artillery.Application.AppPerson.Input;
using Artillery.Application.Interfaces;
using Artillery.Domain.Entities;
using Artillery.Domain.Interfaces.Entities;
using System.Threading.Tasks;

namespace Artillery.Application.AppPerson
{
    public class PersonAppService : IPersonAppService
    {
        public readonly IPersonDomainService _personDomainService;
        public PersonAppService(IPersonDomainService personDomainService)
        {
            _personDomainService = personDomainService;
        }

        public async Task<Person> InsertAsync(PersonInput personInput)
        {
            var person = new Person(personInput.Cpf, personInput.Name, personInput.Birthday);
            return await _personDomainService.InsertAsync(person);
        }
    }
}
