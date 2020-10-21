using System;
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
        [Display(Name = "Author")]
        public string ReviewerName { get; set; }
        public int Rating { get; set; }
        public string ReviewDate { get; set; }
        [Display(Name = "Album")]
        public int AlbumId { get; set; }
        public virtual Album Album { get; set; }

        public Review()
        { 
        
        }

        public Review(int id, string content, string reviewerName, int rating, string reviewDate, int albumId)
        {
            Id = id;
            Content = content;
            ReviewerName = reviewerName;
            Rating = rating;
            ReviewDate = reviewDate;
            AlbumId = albumId;
        }
    }
}
