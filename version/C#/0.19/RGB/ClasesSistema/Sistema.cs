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
            return (byte)L_usuarios.Count;
        }

        public void Agregar_Usuario(Usuario usuario)
        {
            L_usuarios.Add(usuario);
        }
        public void Eliminar_Usuario(Usuario usuario)
        {
            for (int i = 0; i < L_usuarios.Count; i++)
            {
                if (L_usuarios[i] == usuario)
                {
                    L_usuarios.RemoveAt(i);
                }
            }
        }


    }
}
