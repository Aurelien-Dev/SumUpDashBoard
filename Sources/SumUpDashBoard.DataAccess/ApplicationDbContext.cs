using Microsoft.EntityFrameworkCore;
using SumUpDashBoard.BusinessModels.ComptabilityModels;

namespace SumUpDashBoard.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public DbSet<SumUpTransactionModel> SumUpTransactions { get; set; } = default!;
        public DbSet<TransactionModel> Transactions { get; set; } = default!;
        public DbSet<UrsaffTrimesterModel> UrsaffTrimesters { get; set; } = default!;

        public ApplicationDbContext()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true); 
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SumUpTransactionModel>().HasKey(p => p.Id);
            modelBuilder.Entity<SumUpTransactionModel>().Property(p => p.Id).ValueGeneratedOnAdd();


            modelBuilder.Entity<TransactionModel>().HasKey(p => p.Id);
            modelBuilder.Entity<TransactionModel>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<TransactionModel>()
                            .HasOne(s => s.Trimester)
                            .WithMany(g => g.Transactions)
                            .HasForeignKey(s => s.TrimesterId);
            modelBuilder.Entity<TransactionModel>()
                            .HasOne(s => s.SumUpTransaction)
                            .WithOne(g => g.Transaction)
                            .HasForeignKey<TransactionModel>(s => s.SumUpTransactionId);



            modelBuilder.Entity<UrsaffTrimesterModel>().HasKey(p => p.Id);
            modelBuilder.Entity<UrsaffTrimesterModel>().Property(p => p.Id).ValueGeneratedOnAdd();
        }
    }
}