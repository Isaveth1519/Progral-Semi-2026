using System;
using System.Collections.Generic;

namespace ProyectoFinalSistemaDeRegistroMaferrerWeb.Models;

public partial class Aportacione
{
    public int IdAportacion { get; set; }

    public int IdHabitantes { get; set; }

    public DateOnly? Fecha { get; set; }

    public string Concepto { get; set; } = null!;

    public decimal Monto { get; set; }

    public string? NumComprobante { get; set; }

    public string Estado { get; set; } = null!;

    public virtual Habitante IdHabitantesNavigation { get; set; } = null!;
}
