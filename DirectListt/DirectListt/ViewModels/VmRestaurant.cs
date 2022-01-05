using DirectListt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectListt.ViewModels
{
    public class VmRestaurant : VmLayout
    {
        public List<Booking> Bookings { get; set; }
        public List<Restaurant> Restaurants { get; set; }
        public List<string> AddWishlist { get; set; }
       
        public Restaurant Restaurant { get; set; }
        public List<RestaurantReview> RestaurantReviews { get; set; }
        public string Image { get; set; }


    }
}
