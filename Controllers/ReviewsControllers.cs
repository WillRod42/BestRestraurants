using Microsoft.AspNetCore.Mvc;
using BestRestaurants.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BestRestaurants.Controllers
{
    public class ReviewsController : Controller
    {
      private readonly BestRestaurantsContext _db;

      public ReviewsController(BestRestaurantsContext db)
      {
        _db = db;
      }
      public ActionResult Create(int id)
      {
        ViewBag.RestaurantId = id;
        return View();
      }
      [HttpPost]
      public ActionResult Create(Review review)
      {
        _db.Reviews.Add(review);
        _db.SaveChanges();
        return RedirectToAction("Details", "Restaurant", new {id = review.RestaurantId});
      }
    }
}