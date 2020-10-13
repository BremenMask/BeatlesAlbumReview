﻿using ReviewsSite.Models;
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
                new Album(1, "Please Please Me", "1963", "Early Career", "Review", "Image"),
                new Album(2, "Meet the Beatles", "1964", "Early Career", "Review", "Image"),
                new Album(3, "Hard Day's Night", "1964", "Early Career", "Review", "Image"),
                new Album(4, "Beatles for Sale", "1964", "Early Career", "Review", "Image"),
                new Album(5, "Help!", "1965", "Mid-Career", "Review", "Image"),
                new Album(6, "Rubber Soul", "1965", "Mid-Career", "Review", "Image"),
                new Album(7, "Revolver", "1966", "Mid-Career", "Review", "Image"),
                new Album(8, "Sgt Pepper's Lonely Hearts Club Band", "1967", "Late Career", "Review", "Image"),
                new Album(9, "Magical Mystery Tour", "1967", "Late Career", "Review", "Image"),
                new Album(10, "White Album", "1968", "Late Career", "Review", "Image"),
                new Album(11, "Yellow Submarine", "1969", "Late Career", "Review", "Image"),
                new Album(12, "Abbey Road", "1969", "Late Career", "Review", "Image"),
                new Album(13, "Let It Be", "1970", "Late Career", "Review", "Image")
            };
        }
        public IEnumerable<Album> GetAll()
        {
            return albumsList; 
        }

        public Album GetById(int id)
        {
            return albumsList.Single(c => c.Id == id);
        }
    }
}
