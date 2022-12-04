using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MatchTicketCentre.Infrastructure.Data.Models
{
    public class UserCard
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!;

        [Required]
        public int TicketId { get; set; }

        [Required]
        [ForeignKey(nameof(TicketId))]
        public Ticket Ticket { get; set; } = null!;

        [Required]
        public decimal TotalPrice { get; set; }
    }
}
