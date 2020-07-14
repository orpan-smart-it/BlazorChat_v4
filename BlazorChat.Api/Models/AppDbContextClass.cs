using Microsoft.EntityFrameworkCore;

namespace BlazorChat.Api.Models
{
    public class AppDbContextClass: DbContext
    {
        public AppDbContextClass(DbContextOptions<AppDbContextClass> otions) : base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
