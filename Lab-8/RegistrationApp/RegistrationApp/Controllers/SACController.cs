using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RegistrationApp.Data;
using RegistrationApp.Models;

namespace RegistrationApp.Controllers
{
    public class SACController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SACController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SAC
        public async Task<IActionResult> Index()
        {
            return View(await _context.SACs.ToListAsync());
        }

        // GET: SAC/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sAC = await _context.SACs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sAC == null)
            {
                return NotFound();
            }

            return View(sAC);
        }

        // GET: SAC/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SAC/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,SACId,Role,Email,Password")] SAC sAC)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sAC);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sAC);
        }

        // GET: SAC/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sAC = await _context.SACs.FindAsync(id);
            if (sAC == null)
            {
                return NotFound();
            }
            return View(sAC);
        }

        // POST: SAC/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,SACId,Role,Email,Password")] SAC sAC)
        {
            if (id != sAC.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sAC);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SACExists(sAC.Id))
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
            return View(sAC);
        }

        // GET: SAC/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sAC = await _context.SACs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sAC == null)
            {
                return NotFound();
            }

            return View(sAC);
        }

        // POST: SAC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sAC = await _context.SACs.FindAsync(id);
            if (sAC != null)
            {
                _context.SACs.Remove(sAC);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SACExists(int id)
        {
            return _context.SACs.Any(e => e.Id == id);
        }
    }
}
