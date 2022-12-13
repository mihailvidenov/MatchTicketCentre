using MatchTicketCentre.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTicketCentre.Infrastructure.Data.Configuration
{
    public class LeagueConfiguration : IEntityTypeConfiguration<League>
    {
        public void Configure(EntityTypeBuilder<League> builder)
        {
            builder.HasData(CreateLeagues());
        }

        private List<League> CreateLeagues()
        {
            var leagues = new List<League>();

            League league = new League()
            {
                Id = 1,
                Name = "Premier League",
                CountryId = 1
            };

            leagues.Add(league);

            return leagues;
        }
    }

}
