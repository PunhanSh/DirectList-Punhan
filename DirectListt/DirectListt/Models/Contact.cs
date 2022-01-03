﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectListt.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30), Required]
        public string FirstName { get; set; }
        [MaxLength(30), Required]
        public string LastName { get; set; }
        [MaxLength(50), Required]
        public string Email { get; set; }
        [MaxLength(100),Required]
        public string Subject { get; set; }
        [Column(TypeName = "ntext"), Required]
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
