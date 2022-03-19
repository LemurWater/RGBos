using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RGB.ClasesSistema.Usuarios;

namespace RGB.ClasesSistema
{
    public class Sistema
    {
        //Atributos
        public List<Usuario> l_usuarios = new List<Usuario>();
        public Usuario usuario_activo;

        //Constructores
        public Sistema()
        {

        }
        public Sistema(List<Usuario> l_usuarios)
        {
            L_usuarios = l_usuarios;
        }


        public List<Usuario> L_usuarios
        {
            get
            {
                return l_usuarios;
            }
            set
            {
                l_usuarios = value;
            }
        }


        //Metodos
        public byte Cantidad_Usuarios()
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

        public void Agregar_Usuario(Usuario usuario)
        {
            try
            {
                L_usuarios.Add(usuario);
            }
            catch(Exception ex)
            {
                throw new Exception("Error CLASE Sistema - METODO Agregar_Usuario(Usuario) + " + ex);
            }
        }
        public void Eliminar_Usuario(Usuario usuario)
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
            catch(Exception ex)
            {
                throw new Exception("Error CLASE Sistema - METODO Eliminar_Usuario(Usuario) + " + ex);
            }
        }


    }
}
