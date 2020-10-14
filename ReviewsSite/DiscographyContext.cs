using Microsoft.EntityFrameworkCore;
using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite
{
    public class DiscographyContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=DiscographyDB_102020;Trusted_Connection=True";

            optionsBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionsBuilder);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasData(
                new Album()
                {
                    Id = 1,
                    Name = "Please Please Me",
                    Description = "1963",
                    Image = "PleasePleaseMe.jpg",
                    Category = "Early Career"
                },

                new Album()
                {
                    Id = 2,
                    Name = "Meet the Beatles",
                    Description = "1964",
                    Image = "MeettheBeatles.jpg",
                    Category = "Early Career"
                },

                new Album()
                {
                    Id = 3,
                    Name = "Hard Day's Night",
                    Description = "1964",
                    Image = "HardDaysNight.jpg",
                    Category = "Early Career"
                },

                new Album()
                {
                    Id = 4,
                    Name = "Beatles for Sale",
                    Description = "1964",
                    Image = "BeatlesforSale.jpg",
                    Category = "Early Career"
                },

                new Album()
                {
                    Id = 5,
                    Name = "Help!",
                    Description = "1965",
                    Image = "Help!.jpg",
                    Category = "Mid-Career"
                },

                new Album()
                {
                    Id = 6,
                    Name = "Rubber Soul",
                    Description = "1965",
                    Image = "RubberSoul.jpg",
                    Category = "Mid-Career"
                },

                new Album()
                {
                    Id = 7,
                    Name = "Revolver",
                    Description = "1966",
                    Image = "Revolver.jpg",
                    Category = "Mid-Career"
                },

                new Album()
                {
                    Id = 8,
                    Name = "Sgt. Pepper's Lonely Hearts Club Band",
                    Description = "1967",
                    Image = "SgtPepper.jpg",
                    Category = "Late Career"
                },

                new Album()
                {
                    Id = 9,
                    Name = "Magical Mystery Tour",
                    Description = "1967",
                    Image = "MagicalMysteryTour.jpg",
                    Category = "Late Career"
                },

                new Album()
                {
                    Id = 10,
                    Name = "White Album",
                    Description = "1968",
                    Image = "WhiteAlbum.jpg",
                    Category = "Late Career"
                },

                new Album()
                {
                    Id = 11,
                    Name = "Yellow Submarine",
                    Description = "1969",
                    Image = "YellowSubmarine.jpg",
                    Category = "Late Career"
                },

                new Album()
                {
                    Id = 12,
                    Name = "Abbey Road",
                    Description = "1969",
                    Image = "AbbeyRoad.jpg",
                    Category = "Late Career"
                },

                new Album()
                {
                    Id = 13,
                    Name = "Let It Be",
                    Description = "1970",
                    Image = "LetItBe.jpg",
                    Category = "Late Career"
                });

            base.OnModelCreating(modelBuilder);
        }

    }
}
