using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Extraedge_Assesement.Model
{
    [Table("Consumer")]
    public class Consumer
    {
        [Key]
        public int ConsumerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Emailid { get; set; }
        [Required]
        public int Phone { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
