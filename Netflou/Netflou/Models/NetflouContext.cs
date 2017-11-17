using Netflou.Models;
using Microsoft.EntityFrameworkCore;

namespace Netflou.Models
{
    public class NetflouContext : DbContext
    {
        public DbSet<Film> Films { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=netflou.db");
        }


    }

}
