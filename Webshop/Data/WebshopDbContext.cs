using Microsoft.EntityFrameworkCore;

namespace Webshop.Data
{
    public class WebshopDbContext : DbContext
    {
        public WebshopDbContext(DbContextOptions<WebshopDbContext> options)
            : base(options)
        {

        }
    }
}
