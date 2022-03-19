using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RGB.ClasesSistema.Usuarios;
using RGB.ClasesSistema;

using System.IO;


namespace RGB.ClasesSistema._Complementario
{
    public static class Complementario // Leer valores de Python //falta
    {
        //Atributos
        private static List<Usuario> l_usuarios = new List<Usuario>();
        private static Usuario usuario_activo = new Usuario();

        private static List<Escritorio> l_escritorios = new List<Escritorio>();

        private static List<Accion> l_acciones = new List<Accion>();

        //Control
        private static long id_accion = 1;

        //Acceso
        private static byte bloqueo;

        //Sistema
        private static string direccion_sistema = @"C:\Users\Alice\Documents";



        //Constructores
        /*public Complementario()
        {

        }
        public Complementario(List<Usuario> l_usuarios, Usuario usuario_activo, List<Escritorio> l_escritorios)
        {
            L_usuarios = l_usuarios;
            Usuario_activo = usuario_activo;
            L_escritorios = l_escritorios;
        }*/
        //Accesores
        public static List<Usuario> L_usuarios { get => l_usuarios; set => l_usuarios = value; }
        public static Usuario Usuario_activo { get => usuario_activo; set => usuario_activo = value; }
        public static List<Escritorio> L_escritorios { get => l_escritorios; set => l_escritorios = value; }
        public static byte Bloqueo { get => bloqueo; set => bloqueo = value; }
        public static List<Accion> L_acciones { get => l_acciones; set => l_acciones = value; }
        public static long Id_accion { get => id_accion; set => id_accion = value; }

        //Metodos

        public static bool Registrar_Accion(Acciones acciona, string informacion)
        {
            try
            {
                Accion nueva_accion = new Accion(Id_accion, DateTime.Now, acciona, informacion);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error CLASE Sistema - METODO Registrar_Accion() + " + ex);
            }
        }
        public static byte Cantidad_Usuarios()
        {
            try
            {
                return (byte)L_usuarios.Count;
            }
            catch (Exception ex)
            {
                throw new Exception("Error CLASE Sistema - METODO Cantidad_Usuarios() + " + ex);
            }
        }

        public static void Agregar_Usuario(Usuario usuario)
        {
            try
            {
                L_usuarios.Add(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error CLASE Sistema - METODO Agregar_Usuario(Usuario) + " + ex);
            }
        }
        public static void Eliminar_Usuario(Usuario usuario)
        {
            try
            {
                for (int i = 0; i < L_usuarios.Count; i++)
                {
                    if (L_usuarios[i] == usuario)
                    {
                        L_usuarios.RemoveAt(i);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error CLASE Sistema - METODO Eliminar_Usuario(Usuario) + " + ex);
            }
        }
        public static Usuario Usuario_Activo()
        {
            return Usuario_activo;
        }
        //Usuario
        public static byte Obtener_Usuario_Bloqueo_Intentos()
        {
            try
            {
                return Usuario_activo.Pedir_Bloqueo_Intentos();
            }
            catch(Exception ex)
            {
                throw new Exception("Error Clase: Complementario - Metodo: Obtener_Usuario_Bloqueo_Intentos()" + ex);
            }
        }
        public static byte Obtener_Usuario_Bloqueo_Intentados()
        {
            try
            {
                return  Bloqueo;
            }
            catch (Exception ex)
            {
                throw new Exception("Error Clase: Complementario - Metodo: Obtener_Usuario_Bloqueo_Intentados()" + ex);
            }
        }

        //
        public static bool Agregar_Escritorio(Escritorio escritorio)
        {
            try
            {
                L_escritorios.Add(escritorio);
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception("Error Clase: Complementario - Metodo: Agregar_Escritorio()" + ex);
            }
        }
        public static bool Usar_Escritorio()
        {
            try
            {
                Escritorio _escritorio = new Escritorio();
                L_escritorios.Add(_escritorio);
                 L_escritorios[0].Usar_Escritorio();
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception("Error Clase: Complementario - Metodo: Usar_Escritorio()" + ex);
            }
        }
        public static bool Usar_Escritorio(byte indice)
        {
            try
            {
                L_escritorios[indice].Usar_Escritorio();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error Clase: Complementario - Metodo: Usar_Escritorio(byte)" + ex);
            }
        }
        public static List<Escritorio> Obtener_Escritorios()
        {
            try
            {
                return L_escritorios;
            }
            catch(Exception ex)
            {
                throw new Exception("Error Clase: Complementario - Metodo: Obtener_Escritorios()" + ex);
            }
        }


        //Acceso
        public static byte Acceso_Cantidad_Intentos(Usuario _usuario)
        {
            try
            {
                return Usuario_activo.Pedir_Bloqueo_Intentos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error Clase: Complementario - Metodo: Cantidad_Intentos()" + ex);
            }

        }
        public static bool Acceso_Agregar_Intento()
        {
            try
            {
                Bloqueo++;
                if(Bloqueo == Usuario_activo.Pedir_Bloqueo_Intentos())
                {
                    Acceso_Denegado();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error Clase: Complementario - Metodo: Cantidad_Intentos()" + ex);
            }
        }
        public static bool Acceso_Denegado()//falta
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error Clase: Complementario - Metodo: Acceso_Denegado()" + ex);
            }
        }

        public static bool guardar_acciones(Accion accion)
        {
            try
            {
                l_acciones.Add(accion);
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception("Error Clase: Complementario - Metodo: guardar_acciones(Accion)" + ex);
            }
        }
        //Leer TXT
        public static Usuario Separar_Linea(string linea)
        {
            try
            {
                string[] informacion;
                informacion = linea.Split(',');
                Usuario tmp_usuario = new Usuario(l_usuarios.Count + 1,
                    informacion[0], informacion[1], informacion[2], informacion[3], informacion[4], informacion[5],
                    DateTime.Now, DateTime.Now);
                return tmp_usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Error Clase: Complementario - Metodo: Usuario Separar_Linea(string)" + ex);
            }
        }
        public static bool Leer_Txt_Usuarios()
        {
            try
            {
                string direcccion = \TEST.txt";
                string[] usuarios;
                usuarios = File.ReadAllLines(direcccion);

                foreach (string _l in usuarios)
                {
                    Separar_Linea(_l);
                }
                return true;
            }           
            catch (Exception ex)
            {
                throw new Exception("Error Clase: Complementario - Metodo: Leer_Txt_Usuarios()" + ex);
            }
            
        }
        public static bool Leer_Txt_Avatares()
        {
            try
            {
                string direcccion = direccion_sistema + @"\Avatares.txt";
                string[] imagenes = File.ReadAllLines(direcccion);

                foreach (string _l in usuarios)
                {
                    Separar_Linea(_l);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error Clase: Complementario - Metodo: Leer_Txt_Avatares()" + ex);
            }
        }
    }
}
