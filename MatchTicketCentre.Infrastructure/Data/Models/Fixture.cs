using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MatchTicketCentre.Infrastructure.Data.Models
{
    public class Fixture
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int HomeTeamId { get; set; }

        [Required]
        [ForeignKey(nameof(HomeTeamId))]
        public Team HomeTeam { get; set; } = null!;

        [Required]
        public int AwayTeamId { get; set; }

        [Required]
        [ForeignKey(nameof(AwayTeamId))]
        public Team AwayTeam { get; set; } = null!;

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public bool IsFinished { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public int StadiumId { get; set; }

        [Required]
        [ForeignKey(nameof(StadiumId))]
        public Stadium Stadium { get; set; } = null!;

        [Required]
        public int AdminId { get; set; }

        [Required]
        [ForeignKey(nameof(AdminId))]
        public User Admin { get; set; } = null!;

        public List<Ticket> Tickets { get; set; } = new List<Ticket>();

    }
}
