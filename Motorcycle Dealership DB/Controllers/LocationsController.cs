using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Motorcycle_Dealership_DB.Areas.Identity.Data;
using Motorcycle_Dealership_DB.Models;

namespace Motorcycle_Dealership_DB.Controllers
{
    public class LocationsController : Controller
    {
        private readonly Motorcycle_Dealership_DBContext _context;

        public LocationsController(Motorcycle_Dealership_DBContext context)
        {
            _context = context;
        }

        // GET: Locations
        public async Task<IActionResult> Index()
        {
            return View(await _context.Locations.ToListAsync());
        }

        // GET: Locations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locations = await _context.Locations
                .FirstOrDefaultAsync(m => m.LocationsID == id);
            if (locations == null)
            {
                return NotFound();
            }

            return View(locations);
        }

        // GET: Locations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Locations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LocationsID,Country,City,Address,Zip,ContactNumber")] Locations locations)
        {
            if (ModelState.IsValid)
            {
                _context.Add(locations);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(locations);
        }

        // GET: Locations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locations = await _context.Locations.FindAsync(id);
            if (locations == null)
            {
                return NotFound();
            }
            return View(locations);
        }

        // POST: Locations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LocationsID,Country,City,Address,Zip,ContactNumber")] Locations locations)
        {
            if (id != locations.LocationsID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(locations);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocationsExists(locations.LocationsID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(locations);
        }

        // GET: Locations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locations = await _context.Locations
                .FirstOrDefaultAsync(m => m.LocationsID == id);
            if (locations == null)
            {
                return NotFound();
            }

            return View(locations);
        }

        // POST: Locations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var locations = await _context.Locations.FindAsync(id);
            if (locations != null)
            {
                _context.Locations.Remove(locations);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocationsExists(int id)
        {
            return _context.Locations.Any(e => e.LocationsID == id);
        }
    }
}
