using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_a___Has_a.Clases
{
    internal class CursoVirtual:Curso
    {
        public string Plataforma { get; set; }
        public string Url { get; set; }

        public CursoVirtual(string claveCurso,string nombreCurso,int duracion,Profesor profesor,string plataforma,string url): base(claveCurso, nombreCurso, duracion, profesor)
        {
            Plataforma = plataforma;
            Url = url;
        }

        public override string MostrarInformacion()
        {
            return "Tipo: Curso Virtual" +"\nClave: " + ClaveCurso +"\nNombre: " + NombreCurso +"\nDuración: " + Duracion + " horas" +"\nPlataforma: " + Plataforma +"\nURL: " + Url +"\n\nDatos del Profesor:" +"\n" + Profesor.MostrarInformacion();
        }
    }
}
