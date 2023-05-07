using System.ComponentModel.DataAnnotations;

namespace Labb4_API.Models {

    public class Hobbies {

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<LinksHobbies> LinksPerson { get; set; }

    }

}
