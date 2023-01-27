using Microsoft.AspNetCore.Identity;

namespace WeatherAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
