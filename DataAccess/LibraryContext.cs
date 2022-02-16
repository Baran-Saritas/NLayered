using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class LibraryContext :DbContext
    {

        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>(x =>
            {
                x.ToTable("students");
            });
            modelBuilder.Entity<Book>(x =>
            {
                x.ToTable("books");
            });
            modelBuilder.Entity<Lib_Processes>(x =>
            {
                x.ToTable("lib_processes");
            });


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students{ get; set; }
        public DbSet<Lib_Processes> Lib_Processes { get; set; }
        public DbSet<Book> Books{ get; set; }
    }
}
