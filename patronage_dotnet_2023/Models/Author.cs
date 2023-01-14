using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronage_dotnet_2023.Models
{
    internal class Author
    {
        public int Id { get; set; }
        public String FirstName { get; set; } = null!;
        public String LastName { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public Byte Gender { get; set; }
    }
}
