using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StolenCarPTBackend.Data.VO
{
    public class ModelsVO
    {
        public long Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [ForeignKey("Brands")]
        public long brand_id { get; set; }
        //public virtual Brands? Brands { get; set; }
    }   
}
