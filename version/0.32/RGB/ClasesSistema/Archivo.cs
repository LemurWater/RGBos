using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RGB.ClasesSistema.Usuarios;

namespace RGB.ClasesSistema
{
    //Objeto
    public class Archivo
    {
        private short id;
        private Usuario propietario;
        private string nombre;
        private DateTime fecha_creacion = DateTime.Now;
        private DateTime fecha_edicion = DateTime.Now;
        private string informacion;
        private string notas;

        //Constructores
        public Archivo(short id, Usuario propietario, string nombre, DateTime fecha_creacion, DateTime fecha_edicion, string informacion, string notas)
        {
            Id = id;
            Propietario = propietario;
            Nombre = nombre;
            Fecha_creacion = fecha_creacion;
            Fecha_edicion = fecha_edicion;
            Informacion = informacion;
            Notas = notas;
        }

        //Accesores
        public short Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Error al modificar el nombre del archivo: " + nombre);
                }
                else nombre = value;
            }
        }
        public DateTime Fecha_creacion
        {
            get
            {
                return fecha_creacion;
            }
            set
            {
                if (Fecha_creacion != null)
                {
                    fecha_creacion = value;
                }
                else throw new Exception("Error al modificar fecha de creacion del archivo: " + nombre + " - " + propietario);
            }
        }
        public DateTime Fecha_edicion
        {
            get
            {
                return fecha_edicion;
            }
            set
            {
                if (Fecha_edicion != null)
                {
                    fecha_edicion = value;
                }
                else throw new Exception("Error al modificar la fecha de edicion del archivo: " + nombre + " - " + propietario);
            }
        }
        public string Informacion
        {
            get
            {
                return informacion;
            }
            set
            {
                if (informacion != null)
                {
                    informacion = value;
                }
                else throw new Exception("Error al modificar la informacion del archivo: " + nombre + " - " + propietario);
            }
        }
        public string Notas
        {
            get
            {
                return notas;
            }
            set
            {
                if (notas != null)
                {
                    notas = value;
                }
            }
        }
        internal Usuario Propietario
        {
            get
            {
                return propietario;
            }
            set
            {
                if (propietario != null)
                {
                    propietario = value;
                }
            }
        }
    }
}
