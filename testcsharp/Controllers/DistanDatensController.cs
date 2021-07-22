using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using testcsharp.models;

namespace testcsharp.Controllers
{
    public class DistanDatensController : Controller
    {
        private readonly ATHENATONContext _context;

        public DistanDatensController(ATHENATONContext context)
        {
            _context = context;
        }

        // GET: DistanDatens
        public async Task<IActionResult> Index()
        {
            return View(await _context.DistanDatens.ToListAsync());
        }

        // GET: DistanDatens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var distanDaten = await _context.DistanDatens
                .FirstOrDefaultAsync(m => m.Id == id);
            if (distanDaten == null)
            {
                return NotFound();
            }

            return View(distanDaten);
        }

        // GET: DistanDatens/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DistanDatens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Distanz,DistanzArt,Aktivitätsdauer,DistanzManuellAnpassen,UserId,DistanDatenDatum")] DistanDaten distanDaten)
        {
            if (ModelState.IsValid)
            {
                _context.Add(distanDaten);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(distanDaten);
        }

        // GET: DistanDatens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var distanDaten = await _context.DistanDatens.FindAsync(id);
            if (distanDaten == null)
            {
                return NotFound();
            }
            return View(distanDaten);
        }

        // POST: DistanDatens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Distanz,DistanzArt,Aktivitätsdauer,DistanzManuellAnpassen,UserId,DistanDatenDatum")] DistanDaten distanDaten)
        {
            if (id != distanDaten.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(distanDaten);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DistanDatenExists(distanDaten.Id))
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
            return View(distanDaten);
        }

        // GET: DistanDatens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var distanDaten = await _context.DistanDatens
                .FirstOrDefaultAsync(m => m.Id == id);
            if (distanDaten == null)
            {
                return NotFound();
            }

            return View(distanDaten);
        }

        // POST: DistanDatens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var distanDaten = await _context.DistanDatens.FindAsync(id);
            _context.DistanDatens.Remove(distanDaten);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DistanDatenExists(int id)
        {
            return _context.DistanDatens.Any(e => e.Id == id);
        }
    }
}
