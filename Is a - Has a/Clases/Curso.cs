using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_a___Has_a.Clases
{
    internal class Curso
    {
        public string ClaveCurso { get; set; }
        public string NombreCurso { get; set; }
        public int Duracion { get; set; }
        public Profesor Profesor { get; set; }

        public Curso(string claveCurso, string nombreCurso, int duracion, Profesor profesor)
        {
            ClaveCurso = claveCurso;
            NombreCurso = nombreCurso;
            Duracion = duracion;
            Profesor = profesor;

        }
        public virtual string MostrarInformacion()
        {
            return "Clave: " + ClaveCurso +
                   "\nNombre: " + NombreCurso +
                   "\nDuración: " + Duracion + " horas";
        }

    }
}
