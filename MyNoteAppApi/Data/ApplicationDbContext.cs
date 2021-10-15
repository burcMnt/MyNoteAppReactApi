using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyNoteAppApi.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Note> Notes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Note>().HasData(
                new Note() { Id = 1, Title = "Simple note1", Content = "Lorem ipsum sit amet,consectetur." },
                new Note() { Id = 2, Title = "Simple note2", Content = "Set et luctus dolor, eget ullacorper urna." });
        }
    }
}
