using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB.ClasesSistema
{
    public enum Acciones
    {
        Acceso_Usuario,
        Salida_Usuario,
        Cambiar_Texto,
        Agregar_Programa,
        Quitar_Programa
    }
    public class Accion
    {
        private long id;
        private DateTime fecha;
        private Acciones nombre;
        private string informacion;

        public Accion(long id, DateTime fecha, Acciones nombre, string informacion)
        {
            Id = id;
            Fecha = fecha;
            Nombre = nombre;
            Informacion = informacion;
        }

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Informacion { get => informacion; set => informacion = value; }
        public long Id { get => id; set => id = value; }
        internal Acciones Nombre { get => nombre; set => nombre = value; }
    }
}
