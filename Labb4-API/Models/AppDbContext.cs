using Microsoft.EntityFrameworkCore;

namespace Labb4_API.Models {

    public class AppDbContext : DbContext {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 
        
        

        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Hobbies> Hobbies { get; set; }
        public DbSet<LinksHobbies> LinksHobbies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            //HasData : "seeds" the initial data into the database via migration
            //Person creation
            modelBuilder.Entity<Person>().HasData(new Person { Id = 1, Name = "Lucas", Number = "123123123", LinksHobbies = new List<LinksHobbies>() });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 2, Name = "Edvin", Number = "3459128", LinksHobbies = new List<LinksHobbies>() });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 3, Name = "Emil", Number = "7777777", LinksHobbies = new List<LinksHobbies>() });

            //Hobbies creation
            modelBuilder.Entity<Hobbies>().HasData(new Hobbies { 
                Id = 1, 
                Title = "Programming", 
                Description = "Creating software with computer languages.", 
                LinksPerson = new List<LinksHobbies>() 
            });
            modelBuilder.Entity<Hobbies>().HasData(new Hobbies {
                Id = 2,
                Title = "Running",
                Description = "Racing other people often at 200m races.",
                LinksPerson = new List<LinksHobbies>()
            });
            modelBuilder.Entity<Hobbies>().HasData(new Hobbies {
                Id = 3,
                Title = "Fishing",
                Description = "Catch fish's from a body of water.",
                LinksPerson = new List<LinksHobbies>()
            });
            modelBuilder.Entity<Hobbies>().HasData(new Hobbies {
                Id = 4,
                Title = "Webbdevelopment",
                Description = "Building webbsites with virtual lego (html).",
                LinksPerson = new List<LinksHobbies>()
            });

            //LinkHobbies Creation 
            // Give these & some other hobbies links & link them to a person
            modelBuilder.Entity<LinksHobbies>().HasData(new LinksHobbies { Id = 1, Link = "www.github.com", PersonId = 1, HobbiesId = 1 });
            modelBuilder.Entity<LinksHobbies>().HasData(new LinksHobbies { Id = 2, Link = "www.github.com/lucas-ohlin", PersonId = 1, HobbiesId = 2 });
            modelBuilder.Entity<LinksHobbies>().HasData(new LinksHobbies { Id = 3, Link = "www.lures.com", PersonId = 2, HobbiesId = 3 });
            modelBuilder.Entity<LinksHobbies>().HasData(new LinksHobbies { Id = 4, Link = "www.w3schools.com", PersonId = 2, HobbiesId = 4 });
            modelBuilder.Entity<LinksHobbies>().HasData(new LinksHobbies { Id = 5, Link = "www.fishing.com", PersonId = 3, HobbiesId = 3 });

        }

    }

}
