using System.ComponentModel.DataAnnotations;

namespace EcommercePR.DTOs
{
    public class OrderDTO
    {
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public List<OrderItemDetailsDTO> Items { get; set; }
    }
}
