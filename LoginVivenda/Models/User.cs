using Microsoft.AspNetCore.Identity;

namespace LoginVivenda.Models
{
    public class User : IdentityUser
    {
        public int id { get; set; }
        public string? Username { get; set; }
    }
}
