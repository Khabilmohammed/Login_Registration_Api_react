using Microsoft.AspNetCore.Identity;

namespace Login_Registration_Api.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
    }
}
