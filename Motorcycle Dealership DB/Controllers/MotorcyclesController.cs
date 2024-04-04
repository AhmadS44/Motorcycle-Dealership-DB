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
    public class MotorcyclesController : Controller
    {
        private readonly Motorcycle_Dealership_DBContext _context;

        public MotorcyclesController(Motorcycle_Dealership_DBContext context)
        {
            _context = context;
        }

        // GET: Motorcycles
        public async Task<IActionResult> Index()
        {
            return View(await _context.Motorcycles.ToListAsync());
        }

        // GET: Motorcycles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motorcycles = await _context.Motorcycles
                .FirstOrDefaultAsync(m => m.MotorcyclesID == id);
            if (motorcycles == null)
            {
                return NotFound();
            }

            return View(motorcycles);
        }

        // GET: Motorcycles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Motorcycles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MotorcyclesID,Model,Year,Weight,Colour")] Motorcycles motorcycles)
        {
            if (ModelState.IsValid)
            {
                _context.Add(motorcycles);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(motorcycles);
        }

        // GET: Motorcycles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motorcycles = await _context.Motorcycles.FindAsync(id);
            if (motorcycles == null)
            {
                return NotFound();
            }
            return View(motorcycles);
        }

        // POST: Motorcycles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MotorcyclesID,Model,Year,Weight,Colour")] Motorcycles motorcycles)
        {
            if (id != motorcycles.MotorcyclesID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(motorcycles);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MotorcyclesExists(motorcycles.MotorcyclesID))
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
            return View(motorcycles);
        }

        // GET: Motorcycles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motorcycles = await _context.Motorcycles
                .FirstOrDefaultAsync(m => m.MotorcyclesID == id);
            if (motorcycles == null)
            {
                return NotFound();
            }

            return View(motorcycles);
        }

        // POST: Motorcycles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var motorcycles = await _context.Motorcycles.FindAsync(id);
            if (motorcycles != null)
            {
                _context.Motorcycles.Remove(motorcycles);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MotorcyclesExists(int id)
        {
            return _context.Motorcycles.Any(e => e.MotorcyclesID == id);
        }
    }
}
