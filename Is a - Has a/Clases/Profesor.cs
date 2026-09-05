using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_a___Has_a.Clases
{
    public class Profesor
    {
        public int NumEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public Profesor(int numEmpleado, string nombre, string especialidad)
        {
            NumEmpleado = numEmpleado;
            Nombre = nombre;
            Especialidad = especialidad;
        }
        public string MostrarInformacion()
        {
            return "Número de empleado: " + NumEmpleado +
                   "\nNombre: " + Nombre +
                   "\nEspecialidad: " + Especialidad;
        }
    }
}
