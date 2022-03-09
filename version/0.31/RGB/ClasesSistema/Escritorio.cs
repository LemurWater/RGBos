using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RGB.Interfaces;

namespace RGB.ClasesSistema
{
    public class Escritorio
    {
        static Interface_Escritorio form_escritorio = new Interface_Escritorio();
        static bool crear_escritorio = true;



        public static void Usar_Escritorio()
        {
            try
            {
                Program.Mensaje_Del_Sistema("Escritorio");

                //Forms
                if (crear_escritorio)
                {
                    form_escritorio.ShowDialog();
                    crear_escritorio = false;
                }
                //               
            }
            catch (Exception ex)
            {
                throw new Exception("Error metodo usar_escritorio " + ex);
            }
        }
    }
}
