using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Extraedge_Assesement.Model
{
    [Table("Phone")]
    public class Phone
    {
        [Key]
        public int PhoneId { get; set; }
        [Required]
        public int CompanyId { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]

        public string Details { get; set; }
        [Required]
        public int Price { get; set; }
    }
}
