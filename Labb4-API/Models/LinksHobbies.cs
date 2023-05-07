using System.ComponentModel.DataAnnotations;

namespace Labb4_API.Models {

    public class LinksHobbies {

        [Key]
        public int Id { get; set; }
        public string Link { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int HobbiesId { get; set; }
        public Hobbies Hobbies { get; set; }
 
    }

}
