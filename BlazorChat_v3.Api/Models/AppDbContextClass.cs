using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using BlazorChat_v4.Shared;

namespace BlazorChat.Api.Models
{
    public class AppDbContextClass: DbContext
    {
        public AppDbContextClass(DbContextOptions<AppDbContextClass> options) : base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Contact>().HasData( new Contact(3, "Jack", "Rassel", "first@mail.com"));
            modelBuilder.Entity<Contact>().HasData(new Contact(1, "Anatoliy", "Rassel", "second@mail.com"));
            modelBuilder.Entity<Contact>().HasData(new Contact(2, "Lara", "Rassel", "third@mail.com"));
        }
    }
}
