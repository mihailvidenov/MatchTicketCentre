using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MatchTicketCentre.Infrastructure.Data.Models
{
    public class Stadium
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]

        public string Name { get; set; } = null!;

        [Required]
        [StringLength(150)]
        public string Address { get; set; } = null!;

        [Required]
        public int Capacity { get; set; }

        [Required]
        public bool IsSold { get; set; }

        [Required]
        public int TownId { get; set; }

        [Required]
        [ForeignKey(nameof(TownId))]
        public Town Town { get; set; } = null!;

        public List<Team> Teams { get; set; } = new List<Team>();

        public List<Fixture> Fixtures { get; set; } = new List<Fixture>();

    }
}
