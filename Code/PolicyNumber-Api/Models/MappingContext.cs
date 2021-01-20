using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SuggestiveService.Models.AvailableData;

namespace SuggestiveService.Models
{
    public class MappingContext : IdentityDbContext
    {
       
        public MappingContext(DbContextOptions<MappingContext> options)
       : base(options)
        {
        }
        public DbSet<PolicyNumber> PolicyNumber { get; set; }
       
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                
                optionsBuilder.UseSqlServer(@"Server=tcp:ark-dev.database.windows.net,1433;Database=ark-configuration;;User ID=ark-dev-user;Password=Dora3619;Trusted_Connection=False;Encrypt=True;MultipleActiveResultSets=True;App=EntityFramework;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<PolicyNumber>()
            //.Property(a => a.CurrentNumber)
            //.IsConcurrencyToken()
            //.ValueGeneratedOnAddOrUpdate();

        }

    }
}
