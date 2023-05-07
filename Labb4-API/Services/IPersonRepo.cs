using Labb4_API.Models;

namespace Labb4_API.Services {

    public interface IPersonRepo {

        IEnumerable<Person> GetAll();
 
    }

}
