using System;
using System.Collections.Generic;

namespace ProyectoFinalSistemaDeRegistroMaferrerWeb.Models;

public partial class Habitante
{
    public int IdHabitantes { get; set; }

    public string Código { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public virtual ICollection<Aportacione> Aportaciones { get; set; } = new List<Aportacione>();

    public virtual ICollection<Incidente> Incidentes { get; set; } = new List<Incidente>();

    public virtual ICollection<Visitante> Visitantes { get; set; } = new List<Visitante>();
}
