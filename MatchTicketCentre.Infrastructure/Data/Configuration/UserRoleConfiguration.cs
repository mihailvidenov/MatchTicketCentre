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
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasData(CreateUsersRoles());
        }

        private List<UserRole> CreateUsersRoles()
        {
            var usersRoles = new List<UserRole>();

            usersRoles.Add(new UserRole()
            {
                RoleId = "b03e1ed1-555d-4285-b030-1c0a243512d7",
                UserId = "f800fe70-4f4b-4890-b895-e5c8a3086bee"
            });

           
            return usersRoles;
        }
    }
}
