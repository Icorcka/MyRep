using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GuitarStoreM.Models;
using Microsoft.AspNetCore.Http;

namespace GuitarStoreM.Controllers
{
    public class HomeController : Controller
    {
        private readonly GuitarService db;
        public HomeController(GuitarService context)
        {
            db = context;
        }
        public async Task<IActionResult> Index(FilterViewModel filter)
        {
            var guitars = await db.GetGuitars(filter.MinPrice, filter.MaxPrice, filter.Name);
            var model = new IndexViewModel { Guitars = guitars, Filter = filter };
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Guitar g)
        {
            if (ModelState.IsValid)
            {
                await db.Create(g);
                return RedirectToAction("Index");
            }
            return View(g);
        }
        public async Task<IActionResult> Edit(string id)
        {
            Guitar g = await db.GetGuitar(id);
            if (g == null)
                return NotFound();
            return View(g);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Guitar g)
        {
            if (ModelState.IsValid)
            {
                await db.Update(g);
                return RedirectToAction("Index");
            }
            return View(g);
        }
        public async Task<IActionResult> Delete(string id)
        {
            await db.Remove(id);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> AttachImage(string id)
        {
            Guitar g = await db.GetGuitar(id);
            if (g == null)
                return NotFound();
            return View(g);
        }
        [HttpPost]
        public async Task<ActionResult> AttachImage(string id, IFormFile uploadedFile)
        {
            if (uploadedFile != null)
            {
                await db.StoreImage(id, uploadedFile.OpenReadStream(), uploadedFile.FileName);
            }
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> GetImage(string id)
        {
            var image = await db.GetImage(id);
            if (image == null)
            {
                return NotFound();
            }
            return File(image, "image/png");
        }
    }
}
