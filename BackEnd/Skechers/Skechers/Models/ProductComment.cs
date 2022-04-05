﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Skechers.Models
{
    public class ProductComment:BaseEntity
    {
        public string AppUserId { get; set; }
        public int ProductId { get; set; }
        [StringLength(maximumLength: 500)]
        public string Text { get; set; }
        [StringLength(maximumLength: 100)]
        public string Email { get; set; }
        [StringLength(maximumLength: 50)]
        public string FullName { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedAt { get; set; }
        [Required]
        [Range(1, 5)]
        public int Rate { get; set; }
        public AppUser AppUser { get; set; }
        public Product Product { get; set; }
    }
}
