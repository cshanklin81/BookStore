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

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Books.Any())
            {
                context.AddRange(
                new Book
                {
                    Title = "Les Miserables",
                    AuthorFirstName = "Victor",
                    AuthorLastName = "Hugo",
                    Publisher = "Signet",
                    ISBN = "978-0451419439",
                    Classification = "Fiction",
                    Category = "Classic",
                    NumPages = 1488,
                    Price = 9.95
                },

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
                    NumPages = 944,
                    Price = 14.58

                },

                new Book
                {
                    Title = "The Snowball",
                    AuthorFirstName = "Alice",
                    AuthorLastName = "Schroeder",
                    Publisher = "Bantam",
                    ISBN = "978-0553384611",
                    Classification = "Non-Fiction",
                    Category = "Biography",
                    NumPages = 832,
                    Price = 21.54
                },


                new Book
                {
                    Title = "American Ulysses",
                    AuthorFirstName = "Ronald",
                    AuthorMiddleName = "C.",
                    AuthorLastName = "White",
                    Publisher = "Random House",
                    ISBN = "978-0812981254",
                    Classification = "Non-Fiction",
                    Category = "Biography",
                    NumPages = 864,
                    Price = 11.61
                },

                new Book
                {
                    Title = "Unbroken",
                    AuthorFirstName = "Laura",
                    AuthorLastName = "Hillenbrand",
                    Publisher = "Random House",
                    ISBN = "978-0812974492",
                    Classification = "Non-Fiction",
                    Category = "Biography",
                    NumPages = 528,
                    Price = 13.33
                },

                new Book
                {
                    Title = "The Great Train Robbery",
                    AuthorFirstName = "Michael",
                    AuthorLastName = "Crichton",
                    Publisher = "Vintage",
                    ISBN = "978-0804171281",
                    Classification = "Fiction",
                    Category = "Historical Fiction",
                    NumPages = 288,
                    Price = 15.95
                },

                new Book
                {
                    Title = "Deep Work",
                    AuthorFirstName = "Cal",
                    AuthorLastName = "Newport",
                    Publisher = "Grand Central Publishing",
                    ISBN = "978-1455586691",
                    Classification = "Non-Fiction",
                    Category = "Self-Help",
                    NumPages = 304,
                    Price = 14.99
                },

                new Book
                {
                    Title = "It's Your Ship",
                    AuthorFirstName = "Michael",
                    AuthorLastName = "Abrashoff",
                    Publisher = "Grand Central Publishing",
                    ISBN = "978-1455523023",
                    Classification = "Non-Fiction",
                    Category = "Self-Help",
                    NumPages = 240,
                    Price = 21.66
                },

                new Book
                {
                    Title = "The Virgin Way",
                    AuthorFirstName = "Richard",
                    AuthorLastName = "Branson",
                    Publisher = "Portfolio",
                    ISBN = "978-1591847984",
                    Classification = "Non-Fiction",
                    Category = "Business",
                    NumPages = 400,
                    Price = 29.16
                },

                new Book
                {
                    Title = "Sycamore Row",
                    AuthorFirstName = "John",
                    AuthorLastName = "Grisham",
                    Publisher = "Bantam",
                    ISBN = "978-0553393613",
                    Classification = "Fiction",
                    Category = "Thrillers",
                    NumPages = 642,
                    Price = 15.03
                },

                new Book
                {
                    Title = "The Way of Kings",
                    AuthorFirstName = "Brandon",
                    AuthorLastName = "Sanderson",
                    Publisher = "Tor Books",
                    ISBN = "978-0765326355",
                    Classification = "Fiction",
                    Category = "Epic Fantasy",
                    NumPages = 1007,
                    Price = 8.99
                },

                new Book
                {
                    Title = "Words of Radiance",
                    AuthorFirstName = "Brandon",
                    AuthorLastName = "Sanderson",
                    Publisher = "Tor Books",
                    ISBN = "978-0575093324",
                    Classification = "Fiction",
                    Category = "Epic Fantasy",
                    NumPages = 1087,
                    Price = 8.99
                },

                new Book
                {
                    Title = "Oathbringer",
                    AuthorFirstName = "Brandon",
                    AuthorLastName = "Sanderson",
                    Publisher = "Tor Books",
                    ISBN = "978-0575093348",
                    Classification = "Fiction",
                    Category = "Epic Fantasy",
                    NumPages = 1248,
                    Price = 8.99
                }
                );
                context.SaveChanges();
            };

        }
    }
}
