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
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(CreateCountries());
        }

        private List<Country> CreateCountries()
        {
            var countries = new List<Country>();

            Country country = new Country()
            {
                Id = 1,
                Name = "England"
            };

            countries.Add(country);

            return countries;

        }
    }
}
