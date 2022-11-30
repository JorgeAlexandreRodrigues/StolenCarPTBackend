﻿using System.ComponentModel.DataAnnotations;

namespace StolenCarPTBackend.Data.VO
{
    public class BrandsVO
    {
        public long Id { get; set; }
        [Required]
        [StringLength(40)]
        public string Name { get; set; } = string.Empty;
    }
}