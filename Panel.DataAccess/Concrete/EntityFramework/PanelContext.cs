using System.Data.Entity;
using Panel.Entitites.Concrete;

namespace Panel.DataAccess.Concrete.EntityFramework
{
    public class PanelContext:DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
