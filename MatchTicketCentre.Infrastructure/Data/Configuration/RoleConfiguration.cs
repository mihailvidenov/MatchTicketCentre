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
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(CreateRoles());
        }



        private List<Role> CreateRoles()
        {
            var roles = new List<Role>();

            roles.Add(new Role()
            {
                Id = "b03e1ed1-555d-4285-b030-1c0a243512d7",
                Name = "Admin",
                NormalizedName = "Admin".ToUpper()
            });


            return roles;
        }
    }
}
