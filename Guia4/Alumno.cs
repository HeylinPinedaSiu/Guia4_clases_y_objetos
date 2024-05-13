using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4
{
    //Definicion de la clase alumno
    internal class Alumno
    {
        //Propiedades principales de allumno
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public string Carne { get; set; }

        public Carreras carrera { get; set; }

        public List<double> Calificaciones { get; set; }

        //Constructor para inicar las propiedades del alumno 

        public Alumno(string nombre, int edad, Carreras carrera, string carne)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.carrera = carrera;
            this.Carne = carne;
            Calificaciones = new List<double>();
        }

        public enum Carreras
        {
            Ingenieria_de_Sistemas,
            Ingenieria_en_Computacion,
            Telecomunicaciones,
            Ingenieria_electronica,
             Ingenieria_Civil,
             Ingenieria_Quimica,
             Arquitectura,
        }

        //Metodo para calcular el promdio de calificaciones del alumno
        public double CalcularPromedioCalificaciones()
        {
            if (Calificaciones.Count ==0)
            {
                return 0; //Sino no hay calificaciones, el promedio es 0
            }

            double sumacalificaciones = 0;
            foreach (var calificacion in Calificaciones)
                {
                sumacalificaciones += calificacion;
            }
            return sumacalificaciones / Calificaciones.Count;
        }


        //metodo para obtener si el alumno aprobo (promedio >= 60) o reprobo (promedio < 60)

        public string EstadoAprobación()
        {
            
            double promedio = CalcularPromedioCalificaciones();
            if (promedio >= 60)
            {
                return "Aprobado";
            }
            else
            {
                return "Reprobado";
            }
        }
    }

     
}
