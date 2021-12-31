using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectListt.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Logo { get; set; }
        [NotMapped]
        public IFormFile LogoFile { get; set; }
        [MaxLength(100)]
        public string ContactAddress { get; set; }
        [MaxLength(50)]
        public string ContactEmail { get; set; }
        [MaxLength(30)]
        public string ContactPhone { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(30)]
        public string Phone { get; set; }
        [MaxLength(1000)]
        public string AboutUs { get; set; }
        [MaxLength(200)]
        public string DreamTitle { get; set; }
        [MaxLength(500)]
        public string DreamSubTitle { get; set; }
    }
}
