using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenisElo.Data.Configuration;
using TenisElo.Entities.Model;

namespace TenisElo.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
            : base("name=TenisEloConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Player> Players { get; set; }
        //public virtual DbSet<Match> Matches { get; set; }
        //public virtual DbSet<MatchPlayer> PlayerMatches { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PlayerConfiguration());
            //modelBuilder.Configurations.Add(new MatchConfiguration());
            //modelBuilder.Configurations.Add(new MatchPlayerConfiguration());
        }
    }
}
