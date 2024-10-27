﻿using System.ComponentModel.DataAnnotations;

namespace EcommercePR.DTOs
{
    public class OrderStatusDTO
    {
        [Required]
        public int OrderId { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
