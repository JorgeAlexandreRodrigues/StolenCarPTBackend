using System.ComponentModel.DataAnnotations;

namespace StolenCarPTBackend.Model.Base
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
    }
}
