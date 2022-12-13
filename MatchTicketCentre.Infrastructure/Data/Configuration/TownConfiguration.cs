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
    public class TownConfiguration : IEntityTypeConfiguration<Town>
    {
        public void Configure(EntityTypeBuilder<Town> builder)
        {
            builder.HasData(CreateTowns());
        }

        private List<Town> CreateTowns()
        {
            var towns = new List<Town>();

            Town town = new Town()
            {
                Id = 1,
                Name = "Manchester",
                CountryId = 1
            };

            towns.Add(town);

            return towns;
        }
    }
}
