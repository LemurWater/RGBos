using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB.Interfaces
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        private void Interface_Load(object sender, EventArgs e)
        {

        }
        void Cambiar_Version()
        {

        }

        void Cambiar_Apariencia(bool imagen)
        {
            try
            {
                switch (imagen)
                {
                    case true:
                        break;

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la clase Interface - Metodo: Cambiar_Apariencia(bool)");
            }

        }
            
        void Cambiar_Titulo(string texto)
        {
            try
            {
                switch (imagen)
                {
                    case true:
                        break;

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la clase Interface - Metodo: Cambiar_Apariencia(bool)");
            }
        }

        //Apariencia
        void Cambiar_Fondo(bool _imagen)
        {
            try
            {
                switch (_imagen)
                {
                    case true:
                        break;

                    case false:
                        break;
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Error en la clase Interface - Metodo: Cambiar_Fondo(bool)");
            }
        }
        void Cambiar_TituloTamano(short tamano)
        {
            try
            {
                titulo.Font.Size = new Size(tamano,tamano);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la clase Interface - Metodo: Cambiar_Fondo(bool)");
            }
        }
        //Agregar
    }
}
