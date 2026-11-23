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
    public class HabitantesController : Controller
    {
        private readonly MaferrerDbContext _context;

        public HabitantesController(MaferrerDbContext context)
        {
            _context = context;
        }

        // GET: Habitantes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Habitantes.ToListAsync());
        }

        // GET: Habitantes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var habitante = await _context.Habitantes
                .FirstOrDefaultAsync(m => m.IdHabitantes == id);
            if (habitante == null)
            {
                return NotFound();
            }

            return View(habitante);
        }

        // GET: Habitantes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Habitantes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdHabitantes,CÃ³digo,Nombre,Direccion,Telefono")] Habitante habitante)
        {
            if (ModelState.IsValid)
            {
                _context.Add(habitante);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(habitante);
        }

        // GET: Habitantes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var habitante = await _context.Habitantes.FindAsync(id);
            if (habitante == null)
            {
                return NotFound();
            }
            return View(habitante);
        }

        // POST: Habitantes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdHabitantes,CÃ³digo,Nombre,Direccion,Telefono")] Habitante habitante)
        {
            if (id != habitante.IdHabitantes)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(habitante);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HabitanteExists(habitante.IdHabitantes))
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
            return View(habitante);
        }

        // GET: Habitantes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var habitante = await _context.Habitantes
                .FirstOrDefaultAsync(m => m.IdHabitantes == id);
            if (habitante == null)
            {
                return NotFound();
            }

            return View(habitante);
        }

        // POST: Habitantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var habitante = await _context.Habitantes.FindAsync(id);
            if (habitante != null)
            {
                _context.Habitantes.Remove(habitante);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HabitanteExists(int id)
        {
            return _context.Habitantes.Any(e => e.IdHabitantes == id);
        }
    }
}

