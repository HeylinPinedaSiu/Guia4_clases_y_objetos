using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4
{
    internal class Universidad
    {
        //Lista de los alumnos
        private List<Alumno> listaAlumnos;

        //Construcctor para inicializar la lista de alumnos
          public Universidad()
        {
            listaAlumnos = new List<Alumno>();
        }

        //Metodo estatico para mostrar la lista de los alumnos con detalles 
        public void AgregarAlumno(Alumno alumno)
        {
            listaAlumnos.Add(alumno);
        }

        //Metodo estatico para mostrar la lista de los alumnoss con detalles
        
        public List<Alumno> ObtenerListaAlumnos()
        {
            return listaAlumnos;
        }
}
}
