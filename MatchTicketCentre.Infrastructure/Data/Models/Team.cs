using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MatchTicketCentre.Infrastructure.Data.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; } = null!;


        [Required]
        public string Badge { get; set; } = null!;

        [Required]
        public int StadiumId { get; set; }

        [ForeignKey(nameof(StadiumId))]
        public Stadium Stadium { get; set; } = null!;

        [Required]
        public int LeagueId { get; set; }

        [Required]
        [ForeignKey(nameof(League))]
        public League League { get; set; } = null!;


    }
}
