using System.ComponentModel.DataAnnotations;

namespace EcommercePR.DTOs
{
    public class PaymentStatusDTO
    {
        [Required]
        public int PaymentId { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
