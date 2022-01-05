using DirectListt.Data;
using DirectListt.Models;
using DirectListt.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectListt.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly AppDbContext _context;

        public RestaurantController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string SearchData)
        {
            List<Restaurant> restaurants = _context.Restaurants.Include(rt => rt.RestaurantToTags).ThenInclude(t => t.Tag)
                                                               .Include(rf => rf.RestaurantToFeatures).ThenInclude(f => f.Feature)
                                                               .Include(rm => rm.RestaurantToMenus).ThenInclude(m => m.Menu)
                                                               .ToList();
            string oldData = Request.Cookies["wishlist"];

            List<string> cartList = null;

            if (!string.IsNullOrEmpty(oldData))
            {
                cartList = oldData.Split("-").ToList();
            }

            List<Restaurant> restaurants1 = new List<Restaurant>();

            if (cartList != null)
            {
                foreach (var item in cartList)
                {
                    Restaurant restaurant = _context.Restaurants.FirstOrDefault(i => i.Id.ToString() == item);

                    if (restaurant != null)
                    {
                        restaurants1.Add(restaurant);
                    }
                }
            }


            VmRestaurant model = new VmRestaurant();
            //model.Restaurants = _context.Restaurants.ToList();
            model.Setting = _context.Settings.FirstOrDefault();
            model.Socials = _context.Socials.ToList();
            model.Banner = _context.Banners.FirstOrDefault(b => b.Page.ToLower() == "restaurant");
            model.Restaurants = _context.Restaurants.Where(b => (SearchData != null ? b.Name.Contains(SearchData) : true)).ToList();
            model.Restaurants = restaurants;
            model.AddWishlist = oldData.Split("-").ToList();
            //model.Image = restaurants.FirstOrDefault().RestaurantImages.FirstOrDefault().Name;

            return View(model);
        }
        public IActionResult Detail(int? id)
        {
            Restaurant restaurant1 = null;
            if (id != null)
            {
                restaurant1 = _context.Restaurants.Find(id);
            }


            Setting setting = _context.Settings.FirstOrDefault();
            List<Social> socials = _context.Socials.ToList();
            Restaurant restaurant = _context.Restaurants
                                                            .Include(rt => rt.RestaurantToTags).ThenInclude(t => t.Tag)
                                                            .Include(rf => rf.RestaurantToFeatures).ThenInclude(f => f.Feature)
                                                            .Include(rm => rm.RestaurantToMenus).ThenInclude(m => m.Menu)
                                                            .Include(rr => rr.RestaurantReviews).OrderByDescending(bc => bc.CreatedDate)
                                                            .Include(a => a.Adminstrators)
                                                            .FirstOrDefault(i => i.Id == id);

            VmBooking detail = new VmBooking()
            {
                Socials = socials,
                Setting = setting,
                Restaurant = restaurant,
                Banner = _context.Banners.FirstOrDefault(b => b.Page == "detail of restaurant"),
                RestaurantReview = _context.RestaurantReviews.FirstOrDefault()
            };

            return View(detail);
        }
        [HttpPost]
        public IActionResult Comment(VmBooking vmBookings)
        {
            Setting setting = _context.Settings.FirstOrDefault();
            List<Social> socials = _context.Socials.ToList();
            List<Restaurant> restaurants = _context.Restaurants.ToList();

            VmBooking vmBooking = new VmBooking()
            {
                Socials = socials,
                Setting = setting,
                RestaurantReview = vmBookings.RestaurantReview,
                Restaurant = vmBookings.Restaurant,
                Restaurants = restaurants
            };

            if (ModelState.IsValid)
            {
                vmBookings.RestaurantReview.CreatedDate = DateTime.Now;
                _context.RestaurantReviews.Add(vmBookings.RestaurantReview);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Index", vmBooking);
            }

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
                List<string> cartArr = oldData.Split("-").ToList();
                if (cartArr.Any(a => a == id.ToString()))
                {
                    cartArr.Remove(id.ToString());
                    newData = string.Join("-", cartArr);
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
        public IActionResult Booking()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Booking(VmBooking model)
        {
            Setting setting = _context.Settings.FirstOrDefault();
            List<Social> social = _context.Socials.ToList();

            VmBooking vmBook = new VmBooking()
            {
                Socials = social,
                Setting = setting
            };

            if (ModelState.IsValid)
            {
                if (DateTime.Now <= model.Booking.CreatedDate)
                {

                    model.Booking.RestaurantId = model.Restaurant.Id;
                    _context.Bookings.Add(model.Booking);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }

            return View("Index", model);
        }
    }
}
