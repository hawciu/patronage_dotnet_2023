using patronage_dotnet_2023.Data;
using patronage_dotnet_2023.Models;



namespace patronage_dotnet_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            using (LibraryContext context = new LibraryContext())
            {
                Author sap = new Author()
                {
                    FirstName = "Jan",
                    LastName = "Kowalski",
                    BirthDate = DateTime.Now,
                    Gender = 1
                };
                context.Author.Add(sap);

                context.SaveChanges();

                var xd = context.Author
                    .OrderBy(p => p.LastName);

                foreach (Author a in xd)
                {
                    Console.WriteLine(a.Id);
                    Console.WriteLine(a.FirstName);
                    Console.WriteLine(a.LastName);
                    Console.WriteLine(a.BirthDate);
                    Console.WriteLine(a.Gender);
                }
            }


        }
    }
}