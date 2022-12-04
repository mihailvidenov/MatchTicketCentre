using System.ComponentModel.DataAnnotations;

namespace MatchTicketCentre.Infrastructure.Data.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; } = null!;

        public List<Town> Towns { get; set; } = null!;
    }
}
