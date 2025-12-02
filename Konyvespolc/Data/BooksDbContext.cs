using Microsoft.EntityFrameworkCore;
namespace Konyvespolc.Data
{
    public class BooksDbContext : DbContext
    {
        public BooksDbContext(DbContextOptions<BooksDbContext> options)
            : base(options)
        {

        }
    }
}
