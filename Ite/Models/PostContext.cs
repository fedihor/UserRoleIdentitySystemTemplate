using System.Data.Entity;

namespace Ite.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class PostContext : DbContext
    {
        public PostContext() : base("name=DefaultConnection") { }

        public DbSet<State> States { get; set; }
    }
}