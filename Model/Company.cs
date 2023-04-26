using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Extraedge_Assesement.Model
{
    [Table("Company")]
        public class Company
        {
            [Key]
            public int CompanyId { get; set; }
            [Required]
            public string Name { get; set; }
            [Required]
            public string Details { get; set; }

        }
}