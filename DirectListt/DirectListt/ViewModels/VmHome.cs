using DirectListt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectListt.ViewModels
{
    public class VmHome : VmLayout
    {
        public List<Restaurant> Restaurants { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
