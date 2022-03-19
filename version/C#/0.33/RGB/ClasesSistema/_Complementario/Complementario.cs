using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RGB.ClasesSistema.Usuarios;

namespace RGB.ClasesSistema._Complementario
{
    public class Complementario
    {

        private List<Usuario> l_usuarios;

        public List<Usuario> L_usuarios { get => l_usuarios; set => l_usuarios = value; }

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
            catch (Exception ex)
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
            catch (Exception ex)
            {
                throw new Exception("Error CLASE Sistema - METODO Eliminar_Usuario(Usuario) + " + ex);
            }
        }
    }
}
