using Microsoft.EntityFrameworkCore;

namespace Ingatlan.Data
{
    public class IngatlanDbContext : DbContext
    {
        public IngatlanDbContext(DbContextOptions<IngatlanDbContext> options)
            : base(options)
        {

        }
    }
}
