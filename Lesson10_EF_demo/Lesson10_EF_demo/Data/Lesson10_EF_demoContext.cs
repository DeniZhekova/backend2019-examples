using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lesson10_EF_demo.Models;

namespace Lesson10_EF_demo.Models
{
    public class Lesson10_EF_demoContext : DbContext
    {
        public Lesson10_EF_demoContext (DbContextOptions<Lesson10_EF_demoContext> options)
            : base(options)
        {
        }

        public DbSet<Lesson10_EF_demo.Models.Author> Author { get; set; }
        public DbSet<Lesson10_EF_demo.Models.Book> Book { get; set; }
    }
}
