using DirectListt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectListt.ViewModels
{
    public class VmBlogs
    {
        public List<Blog> Blogs { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Social> Socials { get; set; }
        public CustomUser CustomUser { get; set; }
    }
}
