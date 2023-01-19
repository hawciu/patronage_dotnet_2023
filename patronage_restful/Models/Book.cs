using System.ComponentModel.DataAnnotations.Schema;

namespace patronage_restful.Models
{
    public class Book
    {
        public int Id { get; set; }
        public String Title { get; set; } = null!;
        public String Description { get; set; } = null!;

        [Column(TypeName = "decimal(5,2)")]
        public Decimal Rating { get; set; }
        public String ISBN { get; set; } = null!;
        public DateTime PublicationDate { get; set; }
    }
}
