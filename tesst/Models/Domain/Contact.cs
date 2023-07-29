using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tesst.Models.Domain
{
    [Table("Contacts")]
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Email { get; set; }   

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Content { get; set; }

    }
}
