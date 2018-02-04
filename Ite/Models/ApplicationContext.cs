using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Ite.Models
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext() : base("DefaultConnection") { }

        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }
    }
}