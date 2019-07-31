using AspNetCoreApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreApp.Context
{
    public class ApplicationDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=MyDatabase.db");
        }

        public DbSet<Person> Persons { get; set; }
    }
}