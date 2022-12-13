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
                Id = "f800fe70-4f4b-4890-b895-e5c8a3086bee",
                Email = "mihailvidenov@abv.bg",
                NormalizedEmail = "mihailvidenov@abv.bg".ToUpper(),
                UserName = "mishaka002",
                NormalizedUserName = "mishaka002".ToUpper(),
                FirstName = "Mihail",
                MiddleName = "Filipov",
                LastName = "Videnov",
                PhoneNumber = "0882482373"
            };

            users.Add(user);

            user = new User()
            {
                Id = "7da4940e-881c-4622-85d1-5636853a21e5",
                Email = "k_dimitrov@abv.bg",
                NormalizedEmail = "k_dimitrov@abv.bg".ToUpper(),
                UserName =  "kalata03",
                NormalizedUserName = "kalata03".ToUpper(),
                FirstName = "Kaloyan",
                MiddleName = "Ivanov",
                LastName = "Dimitrov",
                PhoneNumber = "0883473405"
            };

            users.Add(user);

            return users;
        }

    }
}
