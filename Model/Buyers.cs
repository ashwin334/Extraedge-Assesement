using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Extraedge_Assesement.Model
{
    [Table("Buyers")]
    public class Buyers
    {
        [Key]
        public int BuyersId { get; set; }
        [Required]
        public int ConsumerId { get; set; }
        [Required]
        public int PhoneId { get; set; }
        [Required]
        public DateTime BuyersDate { get; set; }
        [Required]
        public int BuyersPrice { get; set; }
        [Required]
        public int Cashback { get; set; }
        [Required]
        public int  FinalPrice{ get; set; } 
    }
}
