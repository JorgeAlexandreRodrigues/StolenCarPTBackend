using StolenCarPTBackend.Model.Base;
using System.ComponentModel.DataAnnotations;

namespace StolenCarPTBackend.Model
{
    public class Brands : BaseEntity
    {
        [Required]
        [StringLength(40)]
        public string Name { get; set; } = string.Empty;
    }
}
