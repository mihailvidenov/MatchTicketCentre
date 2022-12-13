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
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasData(CreateTeams());
        }

        private List<Team> CreateTeams()
        {
            var teams = new List<Team>();

            Team team = new Team()
            {
                Id = 1,
                Name = "Manchester United",
                Badge = "https://logos-world.net/wp-content/uploads/2020/06/Manchester-United-logo-700x394.png",
                StadiumId = 1,
                LeagueId = 1
            };

            teams.Add(team);

            team = new Team()
            {
                Id = 2,
                Name = "Manchester City",
                Badge = "https://logos-world.net/wp-content/uploads/2020/06/Manchester-City-Logo-700x394.png",
                StadiumId = 2,
                LeagueId = 1
            };

            teams.Add(team);

            return teams;
        }
    }
}
