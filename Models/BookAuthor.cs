namespace patronage_restful.Models
{
    public class BookAuthor
    {
        public int Id { get; set; }
        public Book Book { get; set; } = null!;
        public Author Author { get; set; } = null!;
    }
}
