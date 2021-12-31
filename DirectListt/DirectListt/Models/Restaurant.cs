using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DirectListt.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Address { get; set; }
        [MaxLength(1000)]
        public string About { get; set; }
        [MaxLength(30)]
        public string Phone1 { get; set; }
        [MaxLength(30)]
        public string Phone2 { get; set; }
        [MaxLength(30)]
        public string Phone3 { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        [MaxLength(500)]
        public string Location { get; set; }
        [MaxLength(1000)]
        public string LocationText { get; set; }
        public List<RestaurantImage> RestaurantImages { get; set; }
        public List<RestaurantToFeature> RestaurantToFeatures { get; set; }
        public List<Booking> Bookings { get; set; }
        public List<RestaurantReview> RestaurantReviews { get; set; }
        public List<RestaurantToTag> RestaurantToTags { get; set; }
        public List<RestaurantToMenu> RestaurantToMenus { get; set; }
    }
}
