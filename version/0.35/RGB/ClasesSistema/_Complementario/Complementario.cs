using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RGB.ClasesSistema.Usuarios;

namespace RGB.ClasesSistema._Complementario
{
    public static class Complementario
    {
        //Atributos
        private static List<Usuario> l_usuarios = new List<Usuario>();
        private static Usuario usuario_activo = new Usuario();

        private static List<Escritorio> l_escritorios = new List<Escritorio>();

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

        //Metodos
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


    }
}
