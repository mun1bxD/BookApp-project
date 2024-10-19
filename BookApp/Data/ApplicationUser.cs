using Microsoft.AspNetCore.Identity;

namespace BookApp.Data
{
    public class ApplicationUser:IdentityUser
    {
        
        public  string? city { get; set; }

    }
}
