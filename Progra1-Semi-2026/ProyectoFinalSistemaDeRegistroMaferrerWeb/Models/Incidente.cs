using System;
using System.Collections.Generic;

namespace ProyectoFinalSistemaDeRegistroMaferrerWeb.Models;

public partial class Incidente
{
    public int Id { get; set; }

    public DateOnly Fecha { get; set; }

    public string Tipo { get; set; } = null!;

    public string Lugar { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string Estado { get; set; } = null!;

    public int? IdHabitantes { get; set; }

    public virtual Habitante? IdHabitantesNavigation { get; set; }
}
