using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TryOut.Models
{
    public class ChampionsContext:DbContext
    {
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Team> Teams { get; set; }
    }

    class ChampionshipBase:DropCreateDatabaseAlways<ChampionsContext>
    {
        protected override void Seed(ChampionsContext context)
        {
            base.Seed(context);
        }
    }
}