// Estudiante.cs
using System;

namespace AppPruebaParcial_1
{
    class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Calificacion { get; set; }

        public Estudiante(string nombre, int edad, double calificacion)
        {
            Nombre = nombre;
            Edad = edad;
            Calificacion = calificacion;
        }

        // Método para mostrar la información del estudiante
        public void MostrarInformacion()
        {
            Console.WriteLine("Información del Estudiante:");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("Calificación: " + Calificacion);
        }
    }
}
