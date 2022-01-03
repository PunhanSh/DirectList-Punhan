using DirectListt.Data;
using DirectListt.Models;
using DirectListt.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectListt.Controllers
{
    public class BlogListController : Controller
    {
        private readonly AppDbContext _context;

        public BlogListController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string Searchdata)
        {
            VmBlogs model = new VmBlogs();
            model.Blogs = _context.Blogs.ToList();
            model.CustomUser = _context.CustomUsers.FirstOrDefault();
            model.Setting = _context.Settings.FirstOrDefault();
            model.Socials = _context.Socials.ToList();
            model.Banner = _context.Banners.FirstOrDefault(b => b.Page.ToLower() == "list of blogs");
            model.Blogs= _context.Blogs.Where(b=>(Searchdata != null ? b.Name.ToLower().Contains(Searchdata.ToLower()) : true)).ToList();
            return View(model);
        }
        public IActionResult Detail(int? id)
        {
            Blog blog = null;
            Setting setting = _context.Settings.FirstOrDefault();
            List<Social> socials = _context.Socials.ToList();
            List<Blog> blogs = _context.Blogs.ToList();
            CustomUser customUser = _context.CustomUsers.FirstOrDefault();
            Banner banner = _context.Banners.FirstOrDefault(b => b.Page.ToLower() == "detail of blog");
            List<Comment> comments = _context.Comments.Where(i => i.BlogId == id).OrderByDescending(bc => bc.CreatedDate).ToList();
            if (id != null)
            {
                blog = _context.Blogs.Find(id);
            }

            VmBlogs model = new VmBlogs()
            {
                Blogs = blogs,
                Socials = socials,
                Setting = setting,
                Blog = blog,
                CustomUser = customUser,
                Banner = banner,
                Comments = comments
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Comment(VmBlogs vmBlogs)
        {
            Setting setting = _context.Settings.FirstOrDefault();
            List<Social> socials = _context.Socials.ToList();
            List<Blog> blogs = _context.Blogs.ToList();

            if (ModelState.IsValid)
            {
                vmBlogs.Comment.CreatedDate = DateTime.Now;
                _context.Comments.Add(vmBlogs.Comment);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            VmBlogs vmBlog = new VmBlogs()
            {
                Socials = socials,
                Setting = setting,
                Comment = vmBlogs.Comment,
                Blog = vmBlogs.Blog,
                Blogs = blogs
            };



            return View("Index", vmBlog);
        }
    }
}
