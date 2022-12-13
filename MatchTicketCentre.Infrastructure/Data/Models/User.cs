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


        public List<Ticket> Tickets { get; set; } = new List<Ticket>();

        public List<UserRole> UsersRoles { get; set; } = new List<UserRole>();

        public List<UserCard> UserCards { get; set; } = new List<UserCard>();

        public List<Fixture> Fixtures { get; set; } = new List<Fixture>();

    }
}
