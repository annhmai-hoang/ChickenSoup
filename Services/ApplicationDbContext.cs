using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ChickenSoup
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Entry> Entries { get; set; }


        // Some seeding entries
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            // Some seeding entries
            var entry1 = new Entry() {
                Id = 1,
                Name = "Generic Entry 1",
                Category = "Happy",
                Description = "I saw some sunlight today and the weather is a bit warmer!",
                CreatedAt = DateTime.Now,
            };

            var entry2 = new Entry() {
                Id = 2, 
                Name = "Generic Entry 2",
                Category = "Sad",
                Description = "I found out the milk I've been drinking is expired...",
                CreatedAt = DateTime.Now
            };

            var panda = "/images/panda.png";  
            var grinnell = "/images/grinnell.jpg";
            var hmong_dog = "/images/hmong-dog.jpg";
            var sushi= "/images/sushi.jpg";

            var visualEntry1 = new Entry()
            {
                Id = 3,
                Name = "Sample Visual Entry 1",
                Category = "Sample",
                Description = "This is a sample visual entry with an image.",
                CreatedAt = DateTime.Now,
                ImagePath = panda,  
                ImageCaption = "Saw him at San Diego Zoo"
            };

            var visualEntry2 = new Entry()
            {
                Id = 4,
                Name = "Sample Visual Entry 2",
                Category = "Sample",
                Description = "This is another sample visual entry with an image.",
                CreatedAt = DateTime.Now,
                ImagePath = grinnell,  
                ImageCaption = "I recently graduated"
            };

            var visualEntry3 = new Entry()
            {
                Id = 5,
                Name = "Sample Visual Entry 3",
                Category = "Sample",
                Description = "This is another sample visual entry with an image.",
                CreatedAt = DateTime.Now,
                ImagePath = hmong_dog,  
                ImageCaption = "The same breed as my dog!"
            };

            var visualEntry4 = new Entry()
            {
                Id = 6,
                Name = "Sample Visual Entry 4",
                Category = "Sample",
                Description = "This is another sample visual entry with an image.",
                CreatedAt = DateTime.Now,
                ImagePath = sushi,  
                ImageCaption = "I'm so hungry~~"
            };

            modelBuilder.Entity<Entry>().HasData(entry1, entry2, visualEntry1, visualEntry2, visualEntry3, visualEntry4);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Suppress the PendingModelChangesWarning if required
            optionsBuilder.ConfigureWarnings(warnings =>
                warnings.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning));
        }
    }
}