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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(CreateUsers());
        }

        private List<User> CreateUsers()
        {
            var users = new List<User>();

            User user = new User()
            {
                Id = "a98e90bc-1adc-4f87-bb4e-9e12a2d39090",
                Email = "mihailvidenov@abv.bg",
                NormalizedEmail = "mihailvidenov@abv.bg".ToUpper(),
                FirstName = "Mihail",
                MiddleName = "Filipov",
                LastName = "Videnov",
                PhoneNumber = "0882482373",
                EGN = "0251141414"
            };

            users.Add(user);

            user = new User()
            {
                Id = "65474606-d7e0-48a6-a6b3-3136c233dd4d",
                Email = "k_dimitrov@abv.bg",
                NormalizedEmail = "k_dimitrov@abv.bg".ToUpper(),
                FirstName = "Kaloyan",
                MiddleName = "Ivanov",
                LastName = "Dimitrov",
                PhoneNumber = "0883473405",
                EGN = "9905221700"
            };

            users.Add(user);

            return users;
        }

    }
}
