using Microsoft.AspNet.Identity.EntityFramework;

namespace Ite.Models
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() { }

        public string Description { get; set; }
    }
}