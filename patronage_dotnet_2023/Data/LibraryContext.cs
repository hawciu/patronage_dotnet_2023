using patronage_dotnet_2023.Models;
using Microsoft.EntityFrameworkCore;

namespace patronage_dotnet_2023.Data
{
    internal class LibraryContext : DbContext 
    {
        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<BookAuthor> BookAuthor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= localhost; Database= test2; Integrated Security=True; TrustServerCertificate=True;");
        }
    }
}
