using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoFinalSistemaDeRegistroMaferrerWeb.Models;

namespace ProyectoFinalSistemaDeRegistroMaferrerWeb.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly MaferrerDbContext _context;

        public HomeController(MaferrerDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var hoy = DateTime.Today;

            ViewBag.TotalHabitantes = await _context.Habitantes.CountAsync();
            ViewBag.RecaudadoMes = await _context.Aportaciones
                .Where(a => a.Estado == "Solvente" && a.Fecha.HasValue && a.Fecha.Value.Year == hoy.Year && a.Fecha.Value.Month == hoy.Month)
                .SumAsync(a => (decimal?)a.Monto) ?? 0m;
            ViewBag.AportacionesPendientes = await _context.Aportaciones.CountAsync(a => a.Estado == "Pendiente");
            ViewBag.IncidentesAbiertos = await _context.Incidentes.CountAsync(i => i.Estado == "Pendiente" || i.Estado == "Abierto");
            ViewBag.VisitasActivas = await _context.Visitantes.CountAsync(v => v.HoraSalida == null);
            ViewBag.TotalVisitas = await _context.Visitantes.CountAsync();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
