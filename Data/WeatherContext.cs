using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WeatherAPI.Models;

namespace WeatherAPI.Data
{
    public class WeatherContext : IdentityDbContext<ApplicationUser>
    {
        public WeatherContext(DbContextOptions<WeatherContext> options) : base(options)
        {

        }

        //public DbSet<ApplicationUser> WeatherTables { get; set; }
    }
}
