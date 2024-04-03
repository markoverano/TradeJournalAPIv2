using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts
{
    public class TradeJournalDbContext: DbContext
    {
        public DbSet<Journal> Journals { get; set;}
        public DbSet<JournalDetail> JournalDetails { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"");
        }
    }
}
