using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB.ClasesSistema.Usuarios
{
    public class Usuario
    {
        //Atributos
        private short id;
        private Clave clave_usuario;
        private string clave_string;
        private string nombre;
        private Avatar avatar_usuario = new Avatar();

        private DateTime fecha_creacion = DateTime.Now;
        private DateTime fecha_edicion = DateTime.Now;
        private byte bloqueo_intentos = 5;
        private short num_archivos = 0;
        //private List<string> l_informacion = new List<string>();
        private string informacion;
        private string notas = "";


        //Constructores
        public Usuario(short id, 
            string nombre, Clave clave_usuario, string avatar_usuario, byte bloqueo_intentos, string informacion, string notas, 
            DateTime fecha_creacion, DateTime fecha_edicion)
        {
            Id = id;

            Nombre = nombre;
            Clave_usuario = clave_usuario;        
            Avatar_usuario = avatar_usuario;

            this.clave_string = clave_string;

            Fecha_creacion = fecha_creacion;
            Fecha_edicion = fecha_edicion;
            Bloqueo_intentos = bloqueo_intentos;
            Informacion = informacion;
            Notas = notas;
        }

        public Usuario(string clave_string)
        {
            
        }

        //Metodos
        public byte Pedir_Bloqueo_Intentos()
        {
            return Bloqueo_intentos;
        }
        public void Cambiar_Bloqueo_Intentos(byte cantidad)
        {
            Bloqueo_intentos = cantidad;
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
        public Clave Clave_usuario
        {
            get
            {
                return clave_usuario;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("La clave es muy corta! ... Minimo 3 caracteres");
                }
                else clave_usuario = value;
            }
        }

        public string Nombre
        {
            get { return nombre; }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
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
                if (avatar_usuario == value)
                {
                    throw new Exception("El nuevo avatar es el mismo al anterior");
                }
                else avatar_usuario = value;
            }
        }

        public DateTime Fecha_creacion
        {
            get { return fecha_creacion; }

            set { fecha_creacion = value; }
        }
        public DateTime Fecha_edicion
        {
            get { return fecha_edicion; }

            set { fecha_edicion = value; }
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
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
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

        public string Clave_string { get => clave_string; set => clave_string = value; }
    }
}
