using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB.ClasesSistema.Usuarios
{
    public class Clave
    {
        //Atributos
        string clave_texto = "RGB";
        List<List<Clave_Colores>> clave_colores;

        public Clave()
        {
            clave_colores.Add(new List<Clave_Colores> { Clave_Colores.Rojo, Clave_Colores.Verde, Clave_Colores.Azul });
        }
        public Clave(string clave_texto, List<List<Clave_Colores>> clave_colores)
        {
            Clave_texto = clave_texto;
            Clave_colores = clave_colores;
        }

        public string Clave_texto { get => clave_texto; set => clave_texto = value; }
        public List<List<Clave_Colores>> Clave_colores { get => clave_colores; set => clave_colores = value; }


        //Metodos
        public string Obtener_Clave(bool sobrecarga)
        {
            try
            {
                return Clave_texto;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en CLASE Clave - metodo Obtener_Clave() + " + ex);
            }
        }
        public List<List<Clave_Colores>> Obtener_Clave()
        {          
            try
            {
                return Clave_colores;
            }
            catch(Exception ex)
            {
                throw new Exception("Error en CLASE Clave - metodo Obtener_Clave(bool) + " + ex);
            }
        }
        public void Cambiar_Clave(string nueva_clave)
        {
            try
            {
                Clave_texto = nueva_clave;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en CLASE Clave - metodo Cambiar_Clave(string) + " + ex);
            }
        }
        public void Cambiar_Clave(List<List<Clave_Colores>> nueva_clave)
        {
            try
            {
                Clave_colores = nueva_clave;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en CLASE Clave - metodo Cambiar_Clave(List<List<Clave_Colores>>) + " + ex);
            }
        }
    }
}
