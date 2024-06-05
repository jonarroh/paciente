using System.ComponentModel.DataAnnotations;

namespace Nutricionista.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Sexo { get; set; }

        [Display(Name = "Fecha de Nacimiento"), DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        public String Email { get; set; }

        public double Peso { get; set; }

        public double Estatura { get; set; }
    }
}
