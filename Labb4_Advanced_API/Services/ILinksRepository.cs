using Labb4_Advanced_API.Models;

namespace Labb4_Advanced_API.Services
{
    public interface ILinksRepository
    {
        List<string> GetInterestSinglePerson(int id);
        IEnumerable<LinksIntrests> GetAllSinglePerson(int id);
        LinksIntrests GetSingleList(int id);
        LinksIntrests Add(LinksIntrests newEntity);
    }
}
