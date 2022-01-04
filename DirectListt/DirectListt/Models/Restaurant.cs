using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectListt.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string Address { get; set; }
        [Column(TypeName = "ntext")]
        public string About { get; set; }
        [MaxLength(30)]
        public string Phone1 { get; set; }
        [MaxLength(30)]
        public string Phone2 { get; set; }
        [MaxLength(30)]
        public string Phone3 { get; set; }
        [MaxLength(250)]
        public string Website { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime CreatedDate { get; set; }
        [MaxLength(500)]
        public string AddressLocation { get; set; }
        [MaxLength(2000)]
        public string LocationNote { get; set; }
        public List<RestaurantReview> RestaurantReviews { get; set; }
        public List<RestaurantImage> RestaurantImages { get; set; }
        public List<RestaurantToTag> RestaurantToTags { get; set; }
        public List<RestaurantToFeature> RestaurantToFeatures { get; set; }
        public List<RestaurantToMenu> RestaurantToMenus { get; set; }
        public List<Adminstrator> Adminstrators { get; set; }
    }
}
