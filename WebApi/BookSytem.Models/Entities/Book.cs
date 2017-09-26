﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookSytem.Models.Entities
{
    public enum EditionType
    {
        Normal, Promo, Gold
    }

    public enum AgeRestriction
    {
        Minor, Teen, Adult
    }

    public class Book
    {
      
        public int Id { get; set; }

        [MinLength(1), MaxLength(50), Required]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        public EditionType EditionType { get; set; }

        public decimal Price { get; set; }

        public int Copies { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public AgeRestriction AgeRestriction { get; set; }

        public virtual Author Author { get; set; }

        public virtual ICollection<Category> Categories { get; set; } = new List<Category>();

        public virtual ICollection<Book> RelatedBooks { get; set; } = new List<Book>();
    }
}
