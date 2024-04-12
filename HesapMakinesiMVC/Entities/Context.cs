using Microsoft.EntityFrameworkCore;

namespace HesapMakinesiMVC.Entities
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdbname); Database=HesapMakinesi; Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Process> Processes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Process>(p =>
            {
                p.ToTable("Process").HasKey(k => k.ProcessId);
                p.Property(x => x.ProcessId).HasColumnName("ProcessId");
                p.Property(x => x.Number1).HasColumnName("Number1");
                p.Property(x => x.Number2).HasColumnName("Number2");
                p.Property(x => x.Result).HasColumnName("Result");
                p.Property(x => x.ProcessType).HasColumnName("ProcessType");
                p.Property(x => x.CreatedDate).HasColumnName("CreatedDate");
            });
        }
    }
}
