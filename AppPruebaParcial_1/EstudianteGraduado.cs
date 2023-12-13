
using System;

namespace AppPruebaParcial_1
{
    class EstudianteGraduado : Estudiante
    {
        public string Titulo { get; set; }

        public EstudianteGraduado(string nombre, int edad, double calificacion, string titulo)
            : base(nombre, edad, calificacion)
        {
            Titulo = titulo;
        }

        // Método para mostrar la información del estudiante graduado
        public new void MostrarInformacion()
        {
            base.MostrarInformacion(); // Llama al método de la clase base
            Console.WriteLine("Título: " + Titulo);
        }
    }
}
