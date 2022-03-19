using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RGB.ClasesSistema.Usuarios;

namespace RGB.Clases
{
    public class Programa
    {
        private short id;
        private List<Usuario> l_usuarios;
        private string nombre;
        private string version;
        private DateTime fecha_instalacion = DateTime.Now;
        private DateTime fecha_ultimo_acceso = DateTime.Now;
        private string informacion;
        private string notas;

        public Programa()
        {

        }
        public Programa(short id, List<Usuario> l_usuarios, string nombre, string version, DateTime fecha_instalacion, DateTime fecha_ultimo_acceso, string informacion, string notas)
        {
            Id = id;
            L_usuarios = l_usuarios;
            Nombre = nombre;
            Version = version;
            Fecha_instalacion = fecha_instalacion;
            Fecha_ultimo_acceso = fecha_ultimo_acceso;
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
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Version
        {
            get
            {
                return version;
            }
            set
            {
                version = value;
            }
        }
        public DateTime Fecha_instalacion
        {
            get
            {
                return fecha_instalacion;
            }
            set
            {
                if(Fecha_instalacion != null)
                {
                    fecha_instalacion = value;
                }
                else throw new Exception("modificacion: Fecha_instalacion NO VALIDA");
            }
        }
        public DateTime Fecha_ultimo_acceso
        {
            get
            {
                return fecha_ultimo_acceso;
            }
            set
            {
                if (Fecha_ultimo_acceso != null)
                {
                    fecha_ultimo_acceso = value;
                }
                else throw new Exception("modificacion: Fecha de ultimo acceso NO VALIDA");
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
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Programa - Informacion = el texto de la informacion agregada no es valido");
                }
                else informacion = value;
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
                notas = value;
            }
        }
        public List<Usuario> L_usuarios
        {
            get
            {
                return l_usuarios;
            }
            set
            {
                if (value != null) l_usuarios = value;

                else throw new Exception("La variable de usuario para agregar al programa es nula");
            }
        }

        internal List<Usuario> L_usuarios1 { get => l_usuarios; set => l_usuarios = value; }
    }
}
