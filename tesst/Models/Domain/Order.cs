﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tesst.Models.Domain
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Address { get; set; }

        public string Note { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime OrderDate { get; set; }
        public bool Status { get; set; }

        public String UserID { get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; }


        public IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}
