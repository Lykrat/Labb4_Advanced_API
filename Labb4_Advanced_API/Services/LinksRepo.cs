using Labb4_Advanced_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb4_Advanced_API.Services
{
    public class LinksRepo : ILinksRepository
    {
        private SomeDbContext _context;

        public LinksRepo(SomeDbContext context)
        {
            this._context = context;
        }
        public LinksIntrests Add(LinksIntrests newEntity)
        {
            var result = _context.LinksIntrests.Add(newEntity);
            _context.SaveChanges();
            return result.Entity;
        }

        public IEnumerable<LinksIntrests> GetAllSinglePerson(int id)
        {
            return _context.LinksIntrests.Where(p => p.PersonId == id).ToList();
        }

        public List<string> GetInterestSinglePerson(int id)
        {
            //var join = _context.LinksIntrests
            //    .Where(c => c.PersonId == id)
            //    .Include(i => i.Interests)
            //    .Select(s => new { InterestID = s.InterestsId, IntererstTitle = s.Interests.Title })
            //    .ToList();
            //Console.WriteLine(join);
            return _context.LinksIntrests.Include(i=>i.Interests).Where(p=>p.PersonId==id).Select(n=>n.Interests.Title).Distinct().ToList();
        }

        public LinksIntrests GetSingleList(int id)
        {
            return _context.LinksIntrests.FirstOrDefault(l => l.ID == id);
        }
    }
}
