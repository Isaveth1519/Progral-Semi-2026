using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoFinalSistemaDeRegistroMaferrerWeb.Models;

namespace ProyectoFinalSistemaDeRegistroMaferrerWeb.Controllers
{
    [Authorize]
    public class AportacionesController : Controller
    {
        private readonly MaferrerDbContext _context;

        public AportacionesController(MaferrerDbContext context)
        {
            _context = context;
        }

        // GET: Aportaciones
        public async Task<IActionResult> Index(string? buscar)
        {
            ViewData["Buscar"] = buscar;
            var query = _context.Aportaciones.Include(a => a.IdHabitantesNavigation).AsQueryable();
            if (!string.IsNullOrWhiteSpace(buscar))
            {
                query = query.Where(a => a.Concepto.Contains(buscar) || a.Estado.Contains(buscar) || (a.NumComprobante != null && a.NumComprobante.Contains(buscar)) || (a.IdHabitantesNavigation != null && a.IdHabitantesNavigation.Nombre.Contains(buscar)));
            }
            return View(await query.OrderByDescending(a => a.IdAportacion).ToListAsync());
        }

        // GET: Aportaciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aportacione = await _context.Aportaciones
                .Include(a => a.IdHabitantesNavigation)
                .FirstOrDefaultAsync(m => m.IdAportacion == id);
            if (aportacione == null)
            {
                return NotFound();
            }

            return View(aportacione);
        }

        // GET: Aportaciones/Create
        public IActionResult Create()
        {
            ViewData["IdHabitantes"] = new SelectList(_context.Habitantes, "IdHabitantes", "IdHabitantes");
            return View();
        }

        // POST: Aportaciones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdAportacion,IdHabitantes,Fecha,Concepto,Monto,NumComprobante,Estado")] Aportacione aportacione)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aportacione);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdHabitantes"] = new SelectList(_context.Habitantes, "IdHabitantes", "IdHabitantes", aportacione.IdHabitantes);
            return View(aportacione);
        }

        // GET: Aportaciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aportacione = await _context.Aportaciones.FindAsync(id);
            if (aportacione == null)
            {
                return NotFound();
            }
            ViewData["IdHabitantes"] = new SelectList(_context.Habitantes, "IdHabitantes", "IdHabitantes", aportacione.IdHabitantes);
            return View(aportacione);
        }

        // POST: Aportaciones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdAportacion,IdHabitantes,Fecha,Concepto,Monto,NumComprobante,Estado")] Aportacione aportacione)
        {
            if (id != aportacione.IdAportacion)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aportacione);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AportacioneExists(aportacione.IdAportacion))
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
            ViewData["IdHabitantes"] = new SelectList(_context.Habitantes, "IdHabitantes", "IdHabitantes", aportacione.IdHabitantes);
            return View(aportacione);
        }

        // GET: Aportaciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aportacione = await _context.Aportaciones
                .Include(a => a.IdHabitantesNavigation)
                .FirstOrDefaultAsync(m => m.IdAportacion == id);
            if (aportacione == null)
            {
                return NotFound();
            }

            return View(aportacione);
        }

        // POST: Aportaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aportacione = await _context.Aportaciones.FindAsync(id);
            if (aportacione != null)
            {
                _context.Aportaciones.Remove(aportacione);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AportacioneExists(int id)
        {
            return _context.Aportaciones.Any(e => e.IdAportacion == id);
        }
    }
}

