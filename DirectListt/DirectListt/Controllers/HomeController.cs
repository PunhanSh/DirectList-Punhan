using DirectListt.Data;
using DirectListt.Models;
using DirectListt.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DirectListt.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmHome model = new VmHome();
            model.Setting = _context.Settings.FirstOrDefault();
            model.Socials = _context.Socials.ToList();
            model.Blogs = _context.Blogs.OrderByDescending(bc => bc.CreatedDate).Take(3).ToList();
            model.Restaurants = _context.Restaurants
                                                    .Include(rt => rt.RestaurantToTags).ThenInclude(t => t.Tag).ToList();
            return View(model);
        }
        public IActionResult AddWishlist(int? id)
        {
            string oldData = Request.Cookies["wishlist"];
            string newData = null;
            if (string.IsNullOrEmpty(oldData))
            {
                newData = id.ToString();
            }
            else
            {
                List<string> wishlistArr = oldData.Split("-").ToList();
                if (wishlistArr.Any(a => a == id.ToString()))
                {
                    wishlistArr.Remove(id.ToString());
                    newData = string.Join("-", wishlistArr);
                }
                else
                {
                    newData = oldData + "-" + id;
                }
            }

            CookieOptions options = new CookieOptions()
            {
                Expires = DateTime.Now.AddYears(1)
            };
            Response.Cookies.Append("wishlist", newData, options);

            return RedirectToAction("Index");

        }
    }
}
