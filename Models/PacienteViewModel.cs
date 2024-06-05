using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Nutricionista.Models
{
    public class PacienteViewModel
    {
        public List<Paciente> Pacientes { get; set; }

        public SelectList Genero => new SelectList(new[]
        {
            new { Id = "M", Value = "Masculino" },
            new { Id = "F", Value = "Femenino" },
            new { Id = "O", Value = "Otro" }
        }, "Id", "Value");

        public double IMC(Paciente paciente) => paciente.Peso / Math.Pow((paciente.Estatura / 100), 2); 

        public int Edad(Paciente paciente) => DateTime.Now.Year - paciente.FechaNacimiento.Year;

        public string IMCString(Paciente paciente)
        {
            var imc = IMC(paciente);
            return imc < 18.5 ? "Bajo peso" : imc < 24.9 ? "Normal" : imc < 29.9 ? "Sobrepeso" : "Obesidad";
        }

        public string IMCColor(Paciente paciente)
        {
            var imc = IMC(paciente);
            return imc < 18.5 ? "text-warning" : imc < 24.9 ? "text-success" : imc < 29.9 ? "text-warning" : imc < 34.9 ? "text-danger" : "text-danger";
        }
    }
}
