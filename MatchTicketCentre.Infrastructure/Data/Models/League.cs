using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MatchTicketCentre.Infrastructure.Data.Models
{
    public class League
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; } = null!;

        [Required]
        public int CountryId { get; set; }

        [Required]
        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; } = null!;

        public List<Team> Teams { get; set; } = new List<Team>();

    }
}
