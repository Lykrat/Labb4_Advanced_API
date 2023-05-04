using Microsoft.EntityFrameworkCore;

namespace Labb4_Advanced_API.Models
{
    public class SomeDbContext : DbContext
    {
        public SomeDbContext(DbContextOptions<SomeDbContext> options) : base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Interests> Interests { get; set; }
        public DbSet<LinksIntrests> LinksIntrests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            //Persons
            modelBuilder.Entity<Person>().HasData(new Person
            {
                ID = 1,
                Name = "Emil",
                PhoneNumber = "123456789",
                LinksIntrests=new List<LinksIntrests>()
            });
            modelBuilder.Entity<Person>().HasData(new Person
            {
                ID = 2,
                Name = "Isak",
                PhoneNumber = "987654321",
                LinksIntrests = new List<LinksIntrests>()
            });
            modelBuilder.Entity<Person>().HasData(new Person
            {
                ID = 3,
                Name = "Lucas",
                PhoneNumber = "000000000",
                LinksIntrests = new List<LinksIntrests>()
            });

            //Inrests
            modelBuilder.Entity<Interests>().HasData(new Interests
            {
                ID=1,
                Title="WoW",
                Description="A MMO game",
                LinksPerson=new List<LinksIntrests>()
            });
            modelBuilder.Entity<Interests>().HasData(new Interests
            {
                ID = 2,
                Title = "Coding",
                Description = "coding",
                LinksPerson = new List<LinksIntrests>()
            });
            modelBuilder.Entity<Interests>().HasData(new Interests
            {
                ID = 3,
                Title = "Fishing",
                Description = "fishing",
                LinksPerson = new List<LinksIntrests>()
            });
            modelBuilder.Entity<Interests>().HasData(new Interests
            {
                ID = 4,
                Title = "Football",
                Description = "A sport",
                LinksPerson = new List<LinksIntrests>()
            });

            //LinksIntrests
            modelBuilder.Entity<LinksIntrests>().HasData(new LinksIntrests
            {
                ID = 1,
                Link ="www.wowhead.com",
                PersonId=1,
                InterestsId=1
            });
            modelBuilder.Entity<LinksIntrests>().HasData(new LinksIntrests
            {
                ID = 2,
                Link = "www.worldofwarcraft.blizzardcom",
                PersonId = 1,
                InterestsId = 1
            });
            modelBuilder.Entity<LinksIntrests>().HasData(new LinksIntrests
            {
                ID = 3,
                Link = "www.learn.microsoft.com",
                PersonId = 1,
                InterestsId = 2
            });
            modelBuilder.Entity<LinksIntrests>().HasData(new LinksIntrests
            {
                ID = 4,
                Link = "www.fiske.se",
                PersonId = 1,
                InterestsId = 3
            });
            modelBuilder.Entity<LinksIntrests>().HasData(new LinksIntrests
            {
                ID = 5,
                Link = "www.Github.com",
                PersonId = 2,
                InterestsId = 2
            });
            modelBuilder.Entity<LinksIntrests>().HasData(new LinksIntrests
            {
                ID = 6,
                Link = "www.github.com",
                PersonId = 3,
                InterestsId = 2
            });
            modelBuilder.Entity<LinksIntrests>().HasData(new LinksIntrests
            {
                ID = 7,
                Link = "www.wikipedia/foorball.com",
                PersonId = 2,
                InterestsId = 4
            });
        }
    }
}
