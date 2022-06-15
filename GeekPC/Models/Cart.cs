using GeekPC.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekPC.Models
{
    public class Cart
    {
        public int Id { get; set; }
        [Required]
        public int ItemId { get; set; }
        public Item Item { get; set; }
        [Required]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
    }
}
