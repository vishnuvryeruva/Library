using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDp.Data;

namespace WebDp.Models
{
    public class Seed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookContext(serviceProvider.GetRequiredService<DbContextOptions<BookContext>>()))
            {
                if (context.Books.Any())
                {
                    return;
                }
                context.Books.AddRange
                (
                    new Book
                    {
                        BTitle = "Ignited Minds",
                        BType = "Educationa",
                        BPrice = 800.00,
                        BAuthor ="A.P.J Abdul Kalam",
                        BPublisher = "Pengwin",
                        BRelease = Convert.ToDateTime("10-09-2000")
                    }
                );
            context.SaveChanges();
            }
        }
    }
}
