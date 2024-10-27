using System.ComponentModel.DataAnnotations;

namespace EcommercePR.DTOs
{
    public class OrderItemDetailsDTO
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
