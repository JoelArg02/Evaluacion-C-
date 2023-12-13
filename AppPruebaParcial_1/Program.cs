using System;

namespace AppPruebaParcial_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                MostrarMenu();

                if (!int.TryParse(Console.ReadLine(), out int opcion) || opcion < 1 || opcion > 6)
                {
                    Console.WriteLine("Selección inválida. Por favor, intente de nuevo.");
                    Continuar();
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        RealizarSuma();
                        break;
                    case 2:
                        Console.Clear();
                        VerificarMayorEdad();
                        break;
                    case 3:
                        Console.Clear();
                        CrearYMostrarEstudiante();
                        break;
                    case 4:
                        Console.Clear();
                        UsarMetodoMostrarInformacion();
                        break;
                    case 5:
                        Console.Clear();
                        CrearYMostrarEstudianteGraduado();
                        break;
                    case 6:

                        return;
                }

                Continuar();
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("Seleccione la prueba deseada:");
            Console.WriteLine("1. Suma de variables");
            Console.WriteLine("2. Verificar mayor de edad");
            Console.WriteLine("3. Crear y mostrar estudiante");
            Console.WriteLine("4. Usar método MostrarInformacion");
            Console.WriteLine("5. Crear y mostrar estudiante graduado");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");
        }

        static void RealizarSuma()
        {
            Console.WriteLine("Pregunta 1 Suma de variables");
            int numero1 = 10;
            int numero2 = 20;
            int resultado = numero1 + numero2;
            Console.WriteLine("La suma entre el número 1 y el número 2 es: ", resultado);        
        }

        static void VerificarMayorEdad()
        {
            Console.WriteLine("Pregunta 2 control IF");
            int edad = 20;
            if (edad >= 18)
            {
                Console.WriteLine("La edad es: " + edad);

                Console.WriteLine("La persona es mayor de edad.");
                }
                else
                {
                Console.WriteLine("La persona no es mayor de edad.");
            }        
        }

        static void CrearYMostrarEstudiante()
        {
            Console.WriteLine("Pregunta 3");
            Estudiante estudiante1 = new Estudiante("Juan Pérez", 20, 8.5);
            Console.WriteLine("Información del Estudiante:");
            Console.WriteLine("Nombre: " + estudiante1.Nombre);
            Console.WriteLine("Edad: " + estudiante1.Edad);
            Console.WriteLine("Calificación: " + estudiante1.Calificacion);        
        }

        static void UsarMetodoMostrarInformacion()
        {
            Estudiante estudiante2 = new Estudiante("Juan Pérez", 20, 8.5);
            estudiante2.MostrarInformacion();        
        }

        static void CrearYMostrarEstudianteGraduado()
        {
            EstudianteGraduado graduado1 = new EstudianteGraduado("Ana Gómez", 25, 9.0, "Ingeniería Informática");

            graduado1.MostrarInformacion();  
        }

        static void Continuar()
        {
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}


