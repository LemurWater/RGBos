using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RGB.Prueba;

using System.Windows.Forms;

namespace RGB.ClasesSistema
{
    public class Inicio
    {
        private static byte image = 2;



        public static void Imprimir()
        {


            try
            {
                switch (image)
                {
                    default:
                        Inicio02.Imprimir();
                        break;

                    case 1:
                        Inicio01.Imprimir();
                        break;

                    case 2:
                        Inicio02.Imprimir();
                        break;

                    case 3:
                        Inicio03.Imprimir();
                        break;
                }



                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
                Console.Clear();
            }
            catch (Exception ex)
            {
                throw new Exception("Error CLASE Inicio - METODO Imprimir() + " + ex);
            }
        }
    }
}
