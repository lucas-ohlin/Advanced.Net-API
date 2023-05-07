using Labb4_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb4_API.Services {

    public class LinkRepo : ILinkRepo {

        private AppDbContext _appDbContext;
        public LinkRepo(AppDbContext appDbContext) { 
            this._appDbContext = appDbContext;
        }

        public LinksHobbies Add(LinksHobbies entity) {

            if (entity != null) {
                _appDbContext.LinksHobbies.Add(entity);
                _appDbContext.SaveChanges();
                return entity;
            } else {
                return null;
            }

        }

        public IEnumerable<LinksHobbies> GetAllSinglePerson(int id) {

            return _appDbContext.LinksHobbies.Where(x => x.PersonId == id).ToList();

        }

        public List<string> GetHobbiesPerson(int id) {

            //Distinct returns distinct variables (uses equality comparer)
            return _appDbContext.LinksHobbies.Include(x => x.Hobbies)
                                             .Where(p => p.PersonId == id)
                                             .Select(h => h.Hobbies.Title).Distinct().ToList();

        }

        public LinksHobbies GetSingleList(int id) {

            return _appDbContext.LinksHobbies.FirstOrDefault(x => x.Id == id);

        }

    }

}
