﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Review
    {
        public int Id { get; set; }
        [MaxLength(160)]
        public string Content { get; set; }
        [Required]
        public string ReviewerName { get; set; }
        public int Rating { get; set; }
        public string ReviewDate { get; set; }
        [Display(Name = "Album")]
        public int AlbumId { get; set; }
        public virtual Album Album { get; set; }
    }
}
