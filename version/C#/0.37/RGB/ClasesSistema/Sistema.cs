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
        private string nombre_proceso;
        private short id_proceso;
        private string notas_proceso;


        //Constructores
        public Sistema()
        {

        }
        public Sistema(string nombre_proceso, short id_proceso)
        {
            Nombre_proceso = nombre_proceso;
            Id_proceso = id_proceso;
            Notas_proceso = notas_proceso;
        }

        //Accesores
        public string Nombre_proceso { get => nombre_proceso; set => nombre_proceso = value; }
        public short Id_proceso { get => id_proceso; set => id_proceso = value; }
        public string Notas_proceso { get => notas_proceso; set => notas_proceso = value; }
    }
}
