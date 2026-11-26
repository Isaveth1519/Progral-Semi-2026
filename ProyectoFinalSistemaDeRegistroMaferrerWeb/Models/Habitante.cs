using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace ProyectoFinalSistemaDeRegistroMaferrerWeb.Models;

public partial class Habitante
{
    public int IdHabitantes { get; set; }

    [Required(ErrorMessage = "El código de casa es obligatorio.")]
    [Display(Name = "Código")]
    public string Codigo { get; set; } = null!;

    [Required(ErrorMessage = "El nombre del habitante es obligatorio.")]
    public string Nombre { get; set; } = null!;

    public string? Direccion { get; set; }

    [RegularExpression(@"^[0-9\-\+\s]{7,20}$", ErrorMessage = "Ingrese un teléfono válido.")]
    public string? Telefono { get; set; }

    public virtual ICollection<Aportacione> Aportaciones { get; set; } = new List<Aportacione>();

    public virtual ICollection<Incidente> Incidentes { get; set; } = new List<Incidente>();

    public virtual ICollection<Visitante> Visitantes { get; set; } = new List<Visitante>();
}

