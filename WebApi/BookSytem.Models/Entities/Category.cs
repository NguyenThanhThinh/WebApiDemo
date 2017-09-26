using System.Collections.Generic;

namespace BookSytem.Models.Entities
{
    using System.ComponentModel.DataAnnotations;
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
