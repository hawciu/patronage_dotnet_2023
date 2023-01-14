using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronage_dotnet_2023.Models
{
    internal class BookAuthor
    {
        public int Id { get; set; }
        public Book Book { get; set; } = null!;
        public Author Author { get; set; } = null!;
    }
}
