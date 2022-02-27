using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB.Clases
{
    internal class Usuario
    {
        public short id;
        public string clave = "RGB";
        public string nombre;
        public DateTime fecha_creacion;
        public DateTime fecha_edicion;
        public byte bloqueo_intentos = 5;
        public short num_archivos = 0;

        public Usuario(short id, string clave, string nombre, DateTime fecha_creacion, DateTime fecha_edicion, byte bloqueo_intentos, short num_archivos)
        {
            this.id = id;
            this.clave = clave;
            this.nombre = nombre;
            this.fecha_creacion = fecha_creacion;
            this.fecha_edicion = fecha_edicion;
            this.bloqueo_intentos = bloqueo_intentos;
            this.num_archivos = num_archivos;
        }
    }
}
