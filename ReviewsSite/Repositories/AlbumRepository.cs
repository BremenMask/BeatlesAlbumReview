using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repositories
{
    public class AlbumRepository
    {
        public List<Album> albumsList;

        public AlbumRepository()
        {
            albumsList = new List<Album>()
            {
                new Album(1, "Please Please Me", "1963"),
                new Album(2, "Meet the Beatles", "1964"),
                new Album(3, "Hard Day's Night", "1964"),
                new Album(4, "Beatles for Sale", "1964"),
                new Album(5, "Help!", "1965"),
                new Album(6, "Rubber Soul", "1965"),
                new Album(7, "Revolver", "1966"),
                new Album(8, "Sgt Pepper's Lonely Hearts Club Band", "1967"),
                new Album(9, "Magical Mystery Tour", "1967"),
                new Album(10, "White Album", "1968"),
                new Album(11, "Yellow Submarine", "1969"),
                new Album(12, "Abbey Road", "1969"),
                new Album(13, "Let It Be", "1970")
            };
        }
    }
}
