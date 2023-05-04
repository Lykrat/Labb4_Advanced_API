using Labb4_Advanced_API.Models;

namespace Labb4_Advanced_API.Services
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAllPersons();
    }
}
