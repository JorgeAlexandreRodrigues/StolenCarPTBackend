using StolenCarPTBackend.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StolenCarPTBackend.Model
{
    public class Models : BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [ForeignKey("Brands")]
        public long brand_id { get; set; }
        public virtual Brands? Brands { get; set; }
    }
}
