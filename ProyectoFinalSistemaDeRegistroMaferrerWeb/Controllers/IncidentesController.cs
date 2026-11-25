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
    public class IncidentesController : Controller
    {
        private readonly MaferrerDbContext _context;

        public IncidentesController(MaferrerDbContext context)
        {
            _context = context;
        }

        // GET: Incidentes
        public async Task<IActionResult> Index(string? buscar)
        {
            ViewData["Buscar"] = buscar;
            var query = _context.Incidentes.Include(i => i.IdHabitantesNavigation).AsQueryable();
            if (!string.IsNullOrWhiteSpace(buscar))
            {
                query = query.Where(i => i.Tipo.Contains(buscar) || i.Lugar.Contains(buscar) || i.Estado.Contains(buscar) || (i.Descripcion != null && i.Descripcion.Contains(buscar)) || (i.IdHabitantesNavigation != null && i.IdHabitantesNavigation.Nombre.Contains(buscar)));
            }
            return View(await query.OrderByDescending(i => i.Id).ToListAsync());
        }

        // GET: Incidentes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incidente = await _context.Incidentes
                .Include(i => i.IdHabitantesNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (incidente == null)
            {
                return NotFound();
            }

            return View(incidente);
        }

        // GET: Incidentes/Create
        public IActionResult Create()
        {
            ViewData["IdHabitantes"] = new SelectList(_context.Habitantes, "IdHabitantes", "IdHabitantes");
            return View();
        }

        // POST: Incidentes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fecha,Tipo,Lugar,Descripcion,Estado,IdHabitantes")] Incidente incidente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(incidente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdHabitantes"] = new SelectList(_context.Habitantes, "IdHabitantes", "IdHabitantes", incidente.IdHabitantes);
            return View(incidente);
        }

        // GET: Incidentes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incidente = await _context.Incidentes.FindAsync(id);
            if (incidente == null)
            {
                return NotFound();
            }
            ViewData["IdHabitantes"] = new SelectList(_context.Habitantes, "IdHabitantes", "IdHabitantes", incidente.IdHabitantes);
            return View(incidente);
        }

        // POST: Incidentes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Fecha,Tipo,Lugar,Descripcion,Estado,IdHabitantes")] Incidente incidente)
        {
            if (id != incidente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(incidente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IncidenteExists(incidente.Id))
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
            ViewData["IdHabitantes"] = new SelectList(_context.Habitantes, "IdHabitantes", "IdHabitantes", incidente.IdHabitantes);
            return View(incidente);
        }

        // GET: Incidentes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incidente = await _context.Incidentes
                .Include(i => i.IdHabitantesNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (incidente == null)
            {
                return NotFound();
            }

            return View(incidente);
        }

        // POST: Incidentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var incidente = await _context.Incidentes.FindAsync(id);
            if (incidente != null)
            {
                _context.Incidentes.Remove(incidente);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IncidenteExists(int id)
        {
            return _context.Incidentes.Any(e => e.Id == id);
        }
    }
}

