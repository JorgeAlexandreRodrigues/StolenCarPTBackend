using System.ComponentModel.DataAnnotations;

namespace StolenCarPTBackend.Model
{
    public class Districts
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Name { get; set; } = string.Empty;

    }
}
