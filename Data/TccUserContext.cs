using Microsoft.EntityFrameworkCore;

namespace tcc.Data
{
    public class TccUserContext : DbContext
    {
        public TccUserContext (DbContextOptions<TccUserContext> options)
            : base(options)
        {
        }

        public DbSet<tcc.Models.User> User { get; set; } = default!;
    }
}
