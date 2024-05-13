using System;

namespace Guia4
{
    internal class Program
    {
        static void Main(String[] ars)
        {
            //creamos la instancia
            Universidad universidad1 = new Universidad();

            Console.WriteLine("▒▒▒▒▒~~~ Bienvenidos al sistema de registro de Alumnos ~~~▒▒▒▒▒");
            Console.WriteLine("**** Datos del Alumno ***** ");
            Console.WriteLine("");

            Alumno alumno1 = new Alumno("Heylin de los Angeles Pineda Siu", 20,Alumno.Carreras.Ingenieria_de_Sistemas,"2023-1013U");
            Alumno alumno2 = new Alumno("Arlen del Socorro Siu Hernandez", 19, Alumno.Carreras.Ingenieria_Quimica,"2023-1503U");
            Alumno alumno3 = new Alumno("Jerson Santiago Villagra Barrantes", 20, Alumno.Carreras.Ingenieria_electronica,"2023-1014U");
            Alumno alumno4 = new Alumno("Antonio Ezequiel Morales Perez", 23, Alumno.Carreras.Ingenieria_en_Computacion, "2020-1712U");
            Alumno alumno5 = new Alumno("Daysi Esther Castillo Hernandez", 22, Alumno.Carreras.Arquitectura, "2021-1504U");

            alumno1.Calificaciones.Add(80);
            alumno1.Calificaciones.Add(75);
            alumno1.Calificaciones.Add(60);
            alumno1.Calificaciones.Add(70);

            alumno2.Calificaciones.Add(65);
            alumno2.Calificaciones.Add(85);
            alumno2.Calificaciones.Add(70);
            alumno2.Calificaciones.Add(90);

            alumno3.Calificaciones.Add(62);
            alumno3.Calificaciones.Add(78);
            alumno3.Calificaciones.Add(85);
            alumno3.Calificaciones.Add(70);

            alumno4.Calificaciones.Add(75);
            alumno4.Calificaciones.Add(83);
            alumno4.Calificaciones.Add(90);
            alumno4.Calificaciones.Add(68);

            alumno5.Calificaciones.Add(55);
            alumno5.Calificaciones.Add(60);
            alumno5.Calificaciones.Add(62);
            alumno5.Calificaciones.Add(60);


            //Agregamos a lista alumno
            universidad1.AgregarAlumno(alumno1);
            universidad1.AgregarAlumno(alumno2);
            universidad1.AgregarAlumno(alumno3);
            universidad1.AgregarAlumno(alumno4);
            universidad1.AgregarAlumno(alumno5);

            foreach (var alumno in universidad1.ObtenerListaAlumnos())
            {
                Console.WriteLine($"Nombre del estudiante:{alumno.Nombre}");
                Console.WriteLine("");

                Console.WriteLine($"Edad del estudiante: {alumno.Edad}");
                Console.WriteLine("");

                Console.WriteLine($"Carrera del estudiante:   { alumno.carrera}");
                Console.WriteLine("");

                Console.WriteLine($"Carnet del estudiante: {alumno.Carne}");
                Console.WriteLine("");

                Console.WriteLine($"Promedio del estudiante:  {alumno.CalcularPromedioCalificaciones()}");
                Console.WriteLine($"Estado de Aprobacion:  { alumno.EstadoAprobación()}");
                Console.WriteLine("");

                Console.WriteLine(" ░░░░░░ El programa ha finalizado  ░░░░░░");

            }


        }
    }
}