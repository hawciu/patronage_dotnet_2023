using patronage_restful.Models;
using Microsoft.EntityFrameworkCore;

namespace patronage_restful.Data
{
    public  class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
            :base(options)
        {
        }

        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<BookAuthor> BookAuthor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server= localhost; Database= patronage_dotnet_2023; Integrated Security=True; TrustServerCertificate=True;");
        }
    }
}
