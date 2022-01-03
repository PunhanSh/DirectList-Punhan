using DirectListt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectListt.ViewModels
{
    public class VmBlogs : VmLayout
    {
        public Comment Comment { get; set; }
        public List<Blog> Blogs { get; set; }
        public Blog Blog { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Social> Socials { get; set; }
        public CustomUser CustomUser { get; set; }
        public Banner Banner { get; set; }
    }
}
