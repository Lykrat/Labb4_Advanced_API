using Labb4_Advanced_API.Models;

namespace Labb4_Advanced_API.Services
{
    public class PersonRepo : IPersonRepository
    {
        private SomeDbContext _context;

        public PersonRepo(SomeDbContext context)
        {
            this._context = context;
        }

        public IEnumerable<Person> GetAllPersons()
        {
            return _context.Persons.ToList();
        }
    }
}
