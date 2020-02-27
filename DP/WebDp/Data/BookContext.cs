using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDp.Models;
using Microsoft.EntityFrameworkCore;

namespace WebDp.Data
{
    public class BookContext:DbContext
    {
        public BookContext(DbContextOptions<BookContext> options):base( options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
