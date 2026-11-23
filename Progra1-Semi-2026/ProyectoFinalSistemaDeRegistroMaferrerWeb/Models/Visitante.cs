using System;
using System.Collections.Generic;

namespace ProyectoFinalSistemaDeRegistroMaferrerWeb.Models;

public partial class Visitante
{
    public int Id { get; set; }

    public DateTime HoraEntrada { get; set; }

    public string NombreVisitante { get; set; } = null!;

    public string NumeroCasa { get; set; } = null!;

    public string Motivo { get; set; } = null!;

    public DateTime? HoraSalida { get; set; }

    public int? IdHabitantes { get; set; }

    public virtual Habitante? IdHabitantesNavigation { get; set; }
}
