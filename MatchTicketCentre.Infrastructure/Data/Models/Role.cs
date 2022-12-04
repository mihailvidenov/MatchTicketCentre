using Microsoft.AspNetCore.Identity;

namespace MatchTicketCentre.Infrastructure.Data.Models
{
    public class Role : IdentityRole
    {
        public List<UserRole> UsersRoles = new List<UserRole>();
    }
}
