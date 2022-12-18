using CRISPR.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CRISPR.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<List<string>>().HasNoKey();
            //base.OnModelCreating(modelBuilder);
        }
        //public DbSet<Code> Codes { get; set; }
        //public DbSet<Comment> Comments { get; set; }
        //public DbSet<DataSet> DataSets{ get; set; }
        //public DbSet<Prop> Props{ get; set; }
    }
}