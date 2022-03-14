using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RGB.ClasesSistema.Usuarios;

namespace RGB.ClasesSistema.Programas
{
    public class Archivo
    {
        private short id;
        private Usuario propietario;
        private string nombre;
        private DateTime fecha_creacion = DateTime.Now;
        private DateTime fecha_edicion = DateTime.Now;
        private string informacion;
        private string notas;

        private char icono = '*';
        private char marco_vertical = '.', marco_horizontal = '.';
        private char relleno = ' ';


        //Constructores
        public Archivo(short id, Usuario propietario, string nombre, DateTime fecha_creacion, DateTime fecha_edicion, 
            string informacion, string notas, char icono, char relleno, char marco_vertical = default, char marco_horizontal = default)
        {
            Id = id;
            Propietario = propietario;
            Nombre = nombre;
            Fecha_creacion = fecha_creacion;
            Fecha_edicion = fecha_edicion;
            Informacion = informacion;
            Notas = notas;

            Icono = icono;
            Marco_vertical = marco_vertical;
            Marco_horizontal = marco_horizontal;
            Relleno = relleno;
        }

        //Metodos
        public char Obtener_Marco_Vertical()
        {
            try
            {
                return Marco_vertical;
            }
            catch(Exception ex)
            {
                throw new Exception("Error Clase: Archivo - Metodo: Obtener_Marco_Vertical()" + ex);
            }
        }
        public char Obtener_Marco_Horizontal()
        {
            try
            {
                return Marco_horizontal;
            }
            catch (Exception ex)
            {
                throw new Exception("Error Clase: Archivo - Metodo: Obtener_Marco_Horizontal()" + ex);
            }
        }
        public char Obtener_Char_Relleno()
        {
            try
            {
                return Relleno;
            }
            catch (Exception ex)
            {
                throw new Exception("Error Clase: Archivo - Metodo: Obtener_Char_Relleno()" + ex);
            }
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


        public Usuario Propietario
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

        public char Icono { get => icono; set => icono = value; }
        public char Marco_vertical { get => marco_vertical; set => marco_vertical = value; }
        public char Marco_horizontal { get => marco_horizontal; set => marco_horizontal = value; }
        public char Relleno { get => relleno; set => relleno = value; }
    }
}
