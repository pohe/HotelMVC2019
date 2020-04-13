using System.Threading.Tasks;
using HotelMVC2019.Data;
using HotelMVC2019.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelMVC2019.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HotelController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HotelController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _db.HotelMvcs.ToListAsync());
        }


        //GEY -CREATE
        public IActionResult Create()
        {
            return View();
        }


        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HotelMVC hotel)
        {
            if (ModelState.IsValid)
            {
                //if valid
                _db.HotelMvcs.Add(hotel);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));

            }
            return View(hotel);
        }

        //GET - EDIT
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var hotel = await _db.HotelMvcs.FindAsync(id);
            if (hotel == null)
            {
                return NotFound();
            }
            return View(hotel);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(HotelMVC hotel)
        {
            if (ModelState.IsValid)
            {
                _db.Update(hotel);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(hotel);
        }

        //GET - Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var hotel = await _db.HotelMvcs.FindAsync(id);
            if (hotel == null)
            {
                return NotFound();
            }
            return View(hotel);

        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var hotel = await _db.HotelMvcs.FindAsync(id);

            if (hotel == null)
            {
                return View();
            }
            _db.HotelMvcs.Remove(hotel);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //GET - DETAILS
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotel = await _db.HotelMvcs.FindAsync(id);
            if (hotel == null)
            {
                return NotFound();
            }

            return View(hotel);
        }
    }
}