using System.ComponentModel.DataAnnotations;
namespace webapp.Moldes
{
    public class Alumno
    {
        [Key]
        public int idAlumno { get; set; }

        public string codigo { get; set; }
        public string nombre { get; set; }
        public int direccion { get; set; }
        public int telefono { get; set; }
        public int email { get; set; }


    }
}
