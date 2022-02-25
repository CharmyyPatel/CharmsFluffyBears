using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CharmsFluffyBears.Data;
using CharmsFluffyBears.Models;

namespace CharmsFluffyBears.Controllers
{
    public class FluffyBearsController : Controller
    {
        private readonly CharmsFluffyBearsContext _context;

        public FluffyBearsController(CharmsFluffyBearsContext context)
        {
            _context = context;
        }

        // GET: FluffyBears
        public async Task<IActionResult> Index()
        {
            return View(await _context.FluffyBears.ToListAsync());
        }

        // GET: FluffyBears/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fluffyBears = await _context.FluffyBears
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fluffyBears == null)
            {
                return NotFound();
            }

            return View(fluffyBears);
        }

        // GET: FluffyBears/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FluffyBears/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductName,ProductDescription,Size,Colour,Price")] FluffyBears fluffyBears)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fluffyBears);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fluffyBears);
        }

        // GET: FluffyBears/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fluffyBears = await _context.FluffyBears.FindAsync(id);
            if (fluffyBears == null)
            {
                return NotFound();
            }
            return View(fluffyBears);
        }

        // POST: FluffyBears/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProductName,ProductDescription,Size,Colour,Price")] FluffyBears fluffyBears)
        {
            if (id != fluffyBears.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fluffyBears);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FluffyBearsExists(fluffyBears.Id))
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
            return View(fluffyBears);
        }

        // GET: FluffyBears/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fluffyBears = await _context.FluffyBears
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fluffyBears == null)
            {
                return NotFound();
            }

            return View(fluffyBears);
        }

        // POST: FluffyBears/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fluffyBears = await _context.FluffyBears.FindAsync(id);
            _context.FluffyBears.Remove(fluffyBears);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FluffyBearsExists(int id)
        {
            return _context.FluffyBears.Any(e => e.Id == id);
        }
    }
}
