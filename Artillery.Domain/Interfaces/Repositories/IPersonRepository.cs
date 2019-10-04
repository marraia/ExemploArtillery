using Artillery.Domain.Entities;
using System.Threading.Tasks;

namespace Artillery.Domain.Interfaces.Repositories
{
    public interface IPersonRepository
    {
        Task InsertAsync(Person person);
    }
}
