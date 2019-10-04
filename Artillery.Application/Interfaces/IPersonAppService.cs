using Artillery.Application.AppPerson.Input;
using Artillery.Domain.Entities;
using System.Threading.Tasks;

namespace Artillery.Application.Interfaces
{
    public interface IPersonAppService
    {
        Task<Person> InsertAsync(PersonInput personInput);
    }
}
