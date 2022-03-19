using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RGB.Sistema.Usuarios;

namespace RGB.Clases
{
    internal class Usuario
    {
        private short id;
        private string clave = "RGB";
        private string nombre;
        private Avatar avatar_usuario = new Avatar();

        private DateTime fecha_creacion = DateTime.Now;
        private DateTime fecha_edicion = DateTime.Now;
        private byte bloqueo_intentos = 5;
        private short num_archivos = 0;
        //private List<string> l_informacion = new List<string>();
        private string informacion;
        private string notas = "";

        public Usuario(short id, string clave, string nombre, DateTime fecha_creacion, DateTime fecha_edicion, byte bloqueo_intentos, short num_archivos, string informacion, string notas)
        {
            Id = id;
            Clave = clave;
            Nombre = nombre;

            Fecha_creacion = fecha_creacion;
            Fecha_edicion = fecha_edicion;
            Bloqueo_intentos = bloqueo_intentos;
            Num_archivos = num_archivos;
            Informacion = informacion;
            Notas = notas;
        }

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
        public string Clave 
        {
            get
            {
                return clave;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new Exception("La clave es muy corta! ... Minimo 3 caracteres");
                }
                else clave = value;
            }
        }

        public string Nombre
        {
            get { return nombre; }

            set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El nombre de usuario no es correcto");
                }
                else nombre = value;
            }
        }
        public Avatar Avatar_usuario
        {
            get
            {
                return avatar_usuario;
            }
            set
            {
                if(avatar_usuario == value)
                {
                    throw new Exception("El nuevo avatar es el mismo al anterior");
                }
                else avatar_usuario = value;
            }
        }

        public DateTime Fecha_creacion
        {
            get { return fecha_creacion; }

            set { fecha_creacion = value;}
        }
        public DateTime Fecha_edicion
        {
            get { return fecha_edicion; }

            set { fecha_edicion = value;}
        }
        public byte Bloqueo_intentos
        {
            get { return bloqueo_intentos; }

            set
            {
                if (value < 1) throw new Exception("Bloque intentos: El valor es cero o negativo");

                else bloqueo_intentos = value;
            }
        }
        public short Num_archivos
        {
            get { return num_archivos; }

            set { num_archivos = value; }
        }
        public string Informacion
        {
            get { return informacion; }

            set
            {            
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("No se agrego informacion");
                }
                else informacion = value;
            }
        }
        public string Notas
        {
            get { return notas; }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("No se agrego notas");
                }
                else notas = value;

            }
        }
    }
}
