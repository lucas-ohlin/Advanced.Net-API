namespace Labb4_API.Models {

    public class Person {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public ICollection<LinksHobbies> LinksHobbies { get; set; }

    }

}
