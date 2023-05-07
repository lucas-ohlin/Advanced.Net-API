using Labb4_API.Models;

namespace Labb4_API.Services {

    public class PersonRepo : IPersonRepo {

        private AppDbContext _appDbContext;
        public PersonRepo(AppDbContext appDbContext) {
            this._appDbContext = appDbContext;
        }

        public IEnumerable<Person> GetAll() {

            return _appDbContext.Person.ToList();

        }

    }

}
