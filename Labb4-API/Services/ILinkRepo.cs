using Labb4_API.Models;

namespace Labb4_API.Services {
    public interface ILinkRepo {

        IEnumerable<LinksHobbies> GetAllSinglePerson(int id);
        List<string> GetHobbiesPerson(int id);
        LinksHobbies GetSingleList(int id);
        LinksHobbies Add(LinksHobbies entity);

    }
}
