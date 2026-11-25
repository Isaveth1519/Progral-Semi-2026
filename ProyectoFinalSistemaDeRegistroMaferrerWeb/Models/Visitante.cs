using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace ProyectoFinalSistemaDeRegistroMaferrerWeb.Models;

public partial class Visitante
{
    public int Id { get; set; }

    public DateTime HoraEntrada { get; set; }

    [Required(ErrorMessage = "El nombre del visitante es obligatorio.")]
    public string NombreVisitante { get; set; } = null!;

    [Required(ErrorMessage = "El número de casa es obligatorio.")]
    public string NumeroCasa { get; set; } = null!;

    [Required(ErrorMessage = "El motivo de visita es obligatorio.")]
    public string Motivo { get; set; } = null!;

    public DateTime? HoraSalida { get; set; }

    public int? IdHabitantes { get; set; }

    public virtual Habitante? IdHabitantesNavigation { get; set; }
}

