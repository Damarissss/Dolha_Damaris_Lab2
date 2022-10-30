using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dolha_Damaris_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        // Foreign key
        public int AuthorID { get; set; }
        // Navigation property. Author property holds a single Author entity (one-to-zero-or-one relationship)
        public Author? Author { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
