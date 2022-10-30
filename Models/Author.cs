namespace Dolha_Damaris_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        // One-many relationship (an author can write multiple books)
        public ICollection<Book> Book { get; set; }
    }
}
