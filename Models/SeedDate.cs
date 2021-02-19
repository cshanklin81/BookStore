using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class SeedDate
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BookstoreDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookstoreDbContext>();

/*            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }*/

            if (!context.Books.Any())
            {
                new Book
                {
                    Title = "Les Miserables",
                    AuthorFirstName = "Victor",
                    AuthorLastName = "Hugo",
                    Publisher = "Signet",
                    ISBN = "978-0451419439",
                    Classification = "Fiction",
                    Category = "Classic",
                    Price = 9.95
                };

                new Book
                {
                    Title = "Team of Rivals",
                    AuthorFirstName = "Doris",
                    AuthorMiddleName = "Kearns",
                    AuthorLastName = "Goodwin",
                    Publisher = "Simon & Schuster",
                    ISBN = "978-0743270755 ",
                    Classification = "Non-Fiction",
                    Category = "Biography",
                    Price = 14.58
                };

                new Book
                {
                    Title = "The Snowball",
                    AuthorFirstName = "Alice",
                    AuthorLastName = "Schroeder",
                    Publisher = "Bantam",
                    ISBN = "978-0553384611",
                    Classification = "Non-Fiction",
                    Category = "Biography",
                    Price = 21.54
                };
            };
            context.SaveChanges();
        }
    }
}
