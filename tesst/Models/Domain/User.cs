﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace tesst.Models.Domain
{
    [Table("Users")]
    public class User : IdentityUser
    {


        public IEnumerable<Order> Orders { get; set; }
    }
}
