using Artillery.Domain.Entities;
using System.Threading.Tasks;

namespace Artillery.Domain.Interfaces.Entities
{
    public interface IPersonDomainService
    {
        Task<Person> InsertAsync(Person person);
    }
}
