namespace LAB_30_31.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int Year { get; set; }
        public int CategoryId { get; set; }

        // Navigation property
        public Category Category { get; set; }
        public Author Author { get; set; }
    }
}
