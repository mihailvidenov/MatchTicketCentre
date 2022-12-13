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
    public class StadiumConfiguration : IEntityTypeConfiguration<Stadium>
    {
        public void Configure(EntityTypeBuilder<Stadium> builder)
        {
            builder.HasData(CreateStadiums());
        }

        private List<Stadium> CreateStadiums()
        {
            var stadiums = new List<Stadium>();

            Stadium stadium = new Stadium()
            {
                Id = 1,
                Name = "Old Trafford",
                Address = "Sir Matt Busby Way, Old Trafford, Stretford, Manchester M16 0RA, United Kingdom",
                Capacity = 74310,
                TownId = 1
            };

            stadiums.Add(stadium);

            stadium = new Stadium()
            {
                Id = 2,
                Name = "Etihad Stadium",
                Address = "Etihad Stadium, Etihad Campus, Manchester M11 3FF, United Kingdom",
                Capacity = 53400,
                TownId = 1
            };

            stadiums.Add(stadium);

            return stadiums;
        }
    }
}
