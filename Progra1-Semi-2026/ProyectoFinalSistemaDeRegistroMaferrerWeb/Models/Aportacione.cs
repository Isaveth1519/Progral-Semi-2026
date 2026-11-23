using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace ProyectoFinalSistemaDeRegistroMaferrerWeb.Models;

public partial class Aportacione
{
    public int IdAportacion { get; set; }

    public int IdHabitantes { get; set; }

    public DateOnly? Fecha { get; set; }

    [Required(ErrorMessage = "El concepto es obligatorio.")]
    public string Concepto { get; set; } = null!;

    [Range(0.01, 100000, ErrorMessage = "El monto debe ser mayor a 0.")]
    public decimal Monto { get; set; }

    public string? NumComprobante { get; set; }

    [Required(ErrorMessage = "El estado es obligatorio.")]
    public string Estado { get; set; } = null!;

    public virtual Habitante IdHabitantesNavigation { get; set; } = null!;
}

