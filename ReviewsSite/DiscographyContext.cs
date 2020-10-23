using Microsoft.EntityFrameworkCore;
using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace ReviewsSite
{
    public class DiscographyContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=DiscographyDB_102020;Trusted_Connection=True";

            optionsBuilder.UseSqlServer(connectionString)
                .UseLazyLoadingProxies();

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

            modelBuilder.Entity<Review>().HasData(
                new Review()
                {
                    Id = 1,
                    Content = "This album is good.",
                    ReviewerName = "Paul McCartney",
                    Rating = 5,
                    ReviewDate = "10/15/2020",
                    AlbumId = 1
                },

                new Review()
                {
                    Id = 2,
                    Content = "This album is really good.",
                    ReviewerName = "John Lennon",
                    Rating = 5,
                    ReviewDate = "10/15/2020",
                    AlbumId = 2
                },

                new Review()
                {
                    Id = 3,
                    Content = "This album is great.",
                    ReviewerName = "George Harrison",
                    Rating = 5,
                    ReviewDate = "10/15/2020",
                    AlbumId = 3
                },

                new Review()
                {
                    Id = 4,
                    Content = "This album is really great.",
                    ReviewerName = "Ringo Starr",
                    Rating = 5,
                    ReviewDate = "10/15/2020",
                    AlbumId = 4
                },

                new Review()
                {
                    Id = 5,
                    Content = "This album is good.",
                    ReviewerName = "Paul McCartney",
                    Rating = 5,
                    ReviewDate = "10/15/2020",
                    AlbumId = 5
                },

                new Review()
                {
                    Id = 6,
                    Content = "This album is really good.",
                    ReviewerName = "John Lennon",
                    Rating = 5,
                    ReviewDate = "10/15/2020",
                    AlbumId = 6
                },

                new Review()
                {
                    Id = 7,
                    Content = "This album is great.",
                    ReviewerName = "George Harrison",
                    Rating = 5,
                    ReviewDate = "10/15/2020",
                    AlbumId = 7
                },

                new Review()
                {
                    Id = 8,
                    Content = "This album is really great.",
                    ReviewerName = "Ringo Starr",
                    Rating = 5,
                    ReviewDate = "10/15/2020",
                    AlbumId = 8
                },

                new Review()
                {
                    Id = 9,
                    Content = "This album is good.",
                    ReviewerName = "Paul McCartney",
                    Rating = 5,
                    ReviewDate = "10/15/2020",
                    AlbumId = 9
                },

                new Review()
                {
                    Id = 10,
                    Content = "This album is really good.",
                    ReviewerName = "John Lennon",
                    Rating = 5,
                    ReviewDate = "10/15/2020",
                    AlbumId = 10
                },

                new Review()
                {
                    Id = 11,
                    Content = "This album is great.",
                    ReviewerName = "George Harrison",
                    Rating = 5,
                    ReviewDate = "10/15/2020",
                    AlbumId = 11
                },

                new Review()
                {
                    Id = 12,
                    Content = "This album is really great.",
                    ReviewerName = "Ringo Starr",
                    Rating = 5,
                    ReviewDate = "10/15/2020",
                    AlbumId = 12
                },

                new Review()
                {
                    Id = 13,
                    Content = "This album is good.",
                    ReviewerName = "Paul McCartney",
                    Rating = 5,
                    ReviewDate = "10/15/2020",
                    AlbumId = 13
                }


                );

            base.OnModelCreating(modelBuilder);
        }

    }
}
