using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GuitarStore.Models;

namespace GuitarStore.Controllers
{
    public class HomeController : Controller
    {
        GuitarStoreContext db;
        public HomeController(GuitarStoreContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Guitars.ToList());
        }
        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.GuitarId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return "Спасибо, " + order.User + ", за покупку!";
        }

    }
}
