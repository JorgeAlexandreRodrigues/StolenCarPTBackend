using StolenCarPTBackend.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StolenCarPTBackend.Model
{
    public class Locations : BaseEntity
    {
        [Required]
        [StringLength(80)]
        public string Name { get; set; } = string.Empty;
        [ForeignKey("Districts")]
        public long district_id { get; set; }
        public virtual Districts? Districts { get; set; }
    }
}
