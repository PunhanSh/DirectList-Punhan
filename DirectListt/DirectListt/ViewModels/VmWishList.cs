using DirectListt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectListt.ViewModels
{
    public class VmWishList
    {
        public List<Restaurant> Restaurants { get; set; }
        public Setting Setting { get; set; }
        public List<Social> Socials { get; set; }
    }
}
