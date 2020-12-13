using Microsoft.EntityFrameworkCore;

namespace ItemsToGetRidOff.Models
{
    public class GetRidOffContext : DbContext
    {
        public GetRidOffContext(DbContextOptions<GetRidOffContext> options)
            : base(options)
        {
        }

        public DbSet<ItemToGetRidOff> Items { get; set; }
    }
}