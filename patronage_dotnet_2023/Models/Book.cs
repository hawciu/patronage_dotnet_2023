using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronage_dotnet_2023.Models
{
    internal class Book
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
