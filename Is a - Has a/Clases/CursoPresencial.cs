using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_a___Has_a.Clases
{
    internal class CursoPresencial:Curso
    {
        // Datos específicos del curso presencial
        public string Salon { get; set; }
        public string Edificio { get; set; }

        // Constructor
        public CursoPresencial(
            string clave,
            string nombre,
            int duracion,
            Profesor profesor,
            string salon,
            string edificio)
            : base(clave, nombre, duracion, profesor)
        {
            Salon = salon;
            Edificio = edificio;
        }

        // Sobrescribe el método de la clase Curso
        public override string MostrarInformacion()
        {
            return "TIPO: PRESENCIAL\n" +
                   "Clave: " + ClaveCurso +
                   "\nNombre: " + NombreCurso +
                   "\nDuración: " + Duracion + " horas" +
                   "\nSalón: " + Salon +
                   "\nEdificio: " + Edificio +
                   "\n\nDATOS DEL PROFESOR\n" +
                   Profesor.MostrarInformacion();
        }

    }
}
