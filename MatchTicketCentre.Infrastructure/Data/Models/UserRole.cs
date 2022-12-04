﻿using Microsoft.AspNetCore.Identity;

namespace MatchTicketCentre.Infrastructure.Data.Models
{
    public class UserRole : IdentityUserRole<string>
    {
        public User User { get; set; } = null!;

        public Role Role { get; set; } = null!;
    }
}
