using Microsoft.AspNet.Identity.EntityFramework;

namespace Ite.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int Year { get; set; }
        public ApplicationUser()
        {
        }
    }
}