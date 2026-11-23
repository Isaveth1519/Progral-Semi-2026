using System.Globalization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoFinalSistemaDeRegistroMaferrerWeb.Models;

namespace ProyectoFinalSistemaDeRegistroMaferrerWeb.Controllers
{
    [Authorize]
    public class ReportesController : Controller
    {
        private readonly MaferrerDbContext _context;

        public ReportesController(MaferrerDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string tipo = "habitantes")
        {
            ViewBag.Tipo = tipo;
            var hoy = DateTime.Today;

            switch (tipo)
            {
                case "aportaciones_mes":
                    var mesNombre = new CultureInfo("es-ES").DateTimeFormat.GetMonthName(hoy.Month);
                    mesNombre = char.ToUpper(mesNombre[0]) + mesNombre.Substring(1);
                    ViewBag.Titulo = $"Aportaciones de {mesNombre} {hoy.Year}";

                    var aportaciones = await _context.Aportaciones
                        .Include(a => a.IdHabitantesNavigation)
                        .Where(a => a.Estado == "Solvente"
                                 && a.Fecha.HasValue
                                 && a.Fecha.Value.Year == hoy.Year
                                 && a.Fecha.Value.Month == hoy.Month)
                        .OrderBy(a => a.Fecha)
                        .ThenBy(a => a.IdHabitantesNavigation!.Nombre)
                        .ToListAsync();

                    ViewBag.Resumen = $"Aportaciones: {aportaciones.Count}   |   Total recaudado: {aportaciones.Sum(a => a.Monto):C2}";
                    return View(aportaciones);

                case "solventes_pendientes":
                    ViewBag.Titulo = "Habitantes solventes y pendientes";
                    var habitantesConPagos = await _context.Habitantes
                        .Include(h => h.Aportaciones)
                        .ToListAsync();

                    var estadoPagos = habitantesConPagos
                        .Select(h => new
                        {
                            Nombre = h.Nombre,
                            Casa = h.Código,
                            PagosPendientes = h.Aportaciones.Count(a => a.Estado == "Pendiente"),
                            MontoAdeudado = h.Aportaciones.Where(a => a.Estado == "Pendiente").Sum(a => a.Monto),
                            Estado = h.Aportaciones.Any(a => a.Estado == "Pendiente") ? "Pendiente" : "Solvente"
                        })
                        .OrderByDescending(x => x.PagosPendientes)
                        .ThenBy(x => x.Nombre)
                        .ToList();

                    int cantPend = estadoPagos.Count(x => x.Estado == "Pendiente");
                    decimal totalDeuda = estadoPagos.Sum(x => x.MontoAdeudado);
                    ViewBag.Resumen = $"Solventes: {estadoPagos.Count - cantPend}   |   Pendientes: {cantPend}   |   Total adeudado: {totalDeuda:C2}";
                    return View(estadoPagos);

                case "visitas":
                    ViewBag.Titulo = "Registro de visitas";
                    var visitas = await _context.Visitantes
                        .Include(v => v.IdHabitantesNavigation)
                        .OrderByDescending(v => v.Id)
                        .ToListAsync();

                    ViewBag.Resumen = $"Total de visitas registradas: {visitas.Count}";
                    return View(visitas);

                case "incidentes":
                    ViewBag.Titulo = "Registro de incidentes";
                    var incidentes = await _context.Incidentes
                        .Include(i => i.IdHabitantesNavigation)
                        .OrderByDescending(i => i.Id)
                        .ToListAsync();

                    int abiertos = incidentes.Count(i =>
                        string.Equals(i.Estado, "Pendiente", StringComparison.OrdinalIgnoreCase) ||
                        string.Equals(i.Estado, "Abierto", StringComparison.OrdinalIgnoreCase));
                    ViewBag.Resumen = $"Total de incidentes: {incidentes.Count}   |   Pendientes/Abiertos: {abiertos}";
                    return View(incidentes);

                default:
                    ViewBag.Tipo = "habitantes";
                    ViewBag.Titulo = "Lista de habitantes";
                    var habitantes = await _context.Habitantes
                        .OrderBy(h => h.Nombre)
                        .ToListAsync();

                    ViewBag.Resumen = $"Total de habitantes: {habitantes.Count}";
                    return View(habitantes);
            }
        }
    }
}
