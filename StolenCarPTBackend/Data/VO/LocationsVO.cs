using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StolenCarPTBackend.Data.VO
{
    public class LocationsVO 
    {
        public long Id { get; set; }
        [Required]
        [StringLength(80)]
        public string Name { get; set; } = string.Empty;
        [ForeignKey("Districts")]
        public long district_id { get; set; }
        //   public virtual Districts? Districts { get; set; }
    }
}
