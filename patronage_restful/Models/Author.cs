namespace patronage_restful.Models
{
    public class Author
    {
        public int Id { get; set; }
        public String FirstName { get; set; } = null!;
        public String LastName { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public Byte Gender { get; set; }
    }
}
