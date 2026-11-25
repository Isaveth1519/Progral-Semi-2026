using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace ProyectoFinalSistemaDeRegistroMaferrerWeb.Models;

public partial class Incidente
{
    public int Id { get; set; }

    public DateOnly Fecha { get; set; }

    [Required(ErrorMessage = "El tipo de incidente es obligatorio.")]
    public string Tipo { get; set; } = null!;

    [Required(ErrorMessage = "El lugar es obligatorio.")]
    public string Lugar { get; set; } = null!;

    public string? Descripcion { get; set; }

    [Required(ErrorMessage = "El estado es obligatorio.")]
    public string Estado { get; set; } = null!;

    public int? IdHabitantes { get; set; }

    public virtual Habitante? IdHabitantesNavigation { get; set; }
}

