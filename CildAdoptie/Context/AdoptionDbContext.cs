using CildAdoptie.Models;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace CildAdoptie.Context
{
    public class AdoptionDbContext : DbContext
    {
        public DbSet<Child> Children { get; set; }
        public DbSet<AdoptionRequest> AdoptionRequests { get; set; }
        public AdoptionDbContext(DbContextOptions<AdoptionDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var children = GetChildrenToSeed();
            modelBuilder.Entity<Child>().HasData(children);
            var adoptionRequests = GetAdoptionRequestsToSeed();
            modelBuilder.Entity<AdoptionRequest>().HasData(adoptionRequests);
        }
        private IEnumerable<Child> GetChildrenToSeed()
        {
            var children = new List<Child>
    {
        new Child { Id = Guid.Parse("7ffa16b3-51ed-4e80-97b6-08dd1f8677e1"), Name = "Anna", Age = 4, Gender = "Female", Description = "Loves painting and playing outdoors." },
        new Child { Id = Guid.Parse("7ffa16b3-51ed-4e80-97b6-08dd1f8677e2"), Name = "Liam", Age = 6, Gender = "Male", Description = "Enjoys puzzles and building blocks." },
        new Child { Id = Guid.Parse("7ffa16b3-51ed-4e80-97b6-08dd1f8677e3"), Name = "Sophia", Age = 3, Gender = "Female", Description = "Very curious and loves to read stories." },
        new Child { Id = Guid.Parse("7ffa16b3-51ed-4e80-97b6-08dd1f8677e4"), Name = "Noah", Age = 5, Gender = "Male", Description = "Passionate about soccer and animals." },
        new Child { Id = Guid.Parse("7ffa16b3-51ed-4e80-97b6-08dd1f8677e5"), Name = "Emma", Age = 7, Gender = "Female", Description = "Loves music and dancing." }
    };
            return children;
        }

        private IEnumerable<AdoptionRequest> GetAdoptionRequestsToSeed()
        {
            var adoptionRequests = new List<AdoptionRequest>
    {
        new AdoptionRequest { Id = Guid.Parse("7ffa16b3-51ed-4e80-97b6-08dd1f8677e6"), ApplicantName = "John Doe", ContactInfo = "johndoe@example.com", ChildId = Guid.Parse("7ffa16b3-51ed-4e80-97b6-08dd1f8677e1") },
        new AdoptionRequest { Id = Guid.Parse("7ffa16b3-51ed-4e80-97b6-08dd1f8677e7"), ApplicantName = "Jane Smith", ContactInfo = "janesmith@example.com", ChildId = Guid.Parse("7ffa16b3-51ed-4e80-97b6-08dd1f8677e2") },
        new AdoptionRequest { Id = Guid.Parse("7ffa16b3-51ed-4e80-97b6-08dd1f8677e8"), ApplicantName = "Michael Brown", ContactInfo = "michaelbrown@example.com", ChildId = Guid.Parse("7ffa16b3-51ed-4e80-97b6-08dd1f8677e3") }
    };
            return adoptionRequests;
        }

    }
}
