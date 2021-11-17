using Betting.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Betting.Data
{
    public class BettingContext : DbContext
    {
        public BettingContext()
        {
            
        }

        public BettingContext(DbContextOptions options)
            : base(options)
        {
        }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Town> Towns { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<PlayerStatistic> PlayerStatistics { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Bet> Bets { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.;Database=Betting;Integrated Security=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayerStatistic>(entity =>
                entity.HasKey(sc => new {sc.PlayerId, sc.GameId}));
            modelBuilder.Entity<Color>(e =>
                e.HasMany<Team>(color => color.PrimaryKitTeams).WithOne(team => team.PrimaryKitColor).OnDelete(DeleteBehavior.NoAction));

            modelBuilder.Entity<Color>(e =>
                e.HasMany<Team>(color => color.SecondaryKitTeams).WithOne(team => team.SecondaryKitColor).OnDelete(DeleteBehavior.NoAction));
            modelBuilder.Entity<Team>(e =>
                e.HasMany(t => t.HomeGames).WithOne(g => g.HomeTeam).OnDelete(DeleteBehavior.NoAction));

            modelBuilder.Entity<Team>(e =>
                e.HasMany(t => t.AwayGames).WithOne(g => g.AwayTeam).OnDelete(DeleteBehavior.NoAction));
        }
    }
}