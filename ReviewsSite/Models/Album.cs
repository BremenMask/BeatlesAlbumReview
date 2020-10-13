﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Album
    {   
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Review { get; set; }
        public string Image { get; set; }
        public Album()
        {

        }

        public Album(int id, string name, string description, string category, string review, string image)
        {
            Id = id;
            Name = name;
            Description = description;
            Category = category;
            Review = review;
            Image = image;
        }
    }
}
