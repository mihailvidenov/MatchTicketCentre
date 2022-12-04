using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MatchTicketCentre.Infrastructure.Data.Models
{
    public class User : IdentityUser
    {
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(30)]
        public string MiddleName { get; set; } = null!;

        [Required]
        [StringLength(30)]
        public string LastName { get; set; } = null!;

        [Required]
        [StringLength(10)]
        public string EGN { get; set; } = null!;

        public List<Ticket> Tickets { get; set; } = null!;

        public List<UserRole> UsersRoles { get; set; } = null!;

        public List<UserCard> UserCards { get; set; } = new List<UserCard>();

    }
}
