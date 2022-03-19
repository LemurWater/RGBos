using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB.ClasesSistema.Programas.Utilidades //✓✓✓☑✓✓✓☑    ☒✗✘
{
    public partial class Interface_Calculadora : Form
    {
        //Atributos
        public enum Operacion { Suma, Resta, Multiplicacion, Division, Residuo, Porcentaje, Elevar, Raiz, Derivacion, Integracion};
        public Operacion operacion;

        public char fraccion = '.';          // , . 
        private bool fraccion_control = false;
        public Interface_Calculadora()
        {
            InitializeComponent();
        }

        private void Interface_Calculadora_Load(object sender, EventArgs e)
        {

        }

        public void Refrescar_Opciones()
        {
            try
            {
                boton_separacion.Text = fraccion.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Error Calculadora - metodo: refrescar opciones" + ex);
            }
        }
        //BOTONES NUMEROS
        private void Click_Boton1(object sender, EventArgs e)
        {
            try
            {
                rtb_ingresar.Text += "1";
            }
            catch(Exception ex)
            {
                throw new Exception("Error calculadora metodo click boton 1" + ex);
            }
        }
        private void Click_Boton2(object sender, EventArgs e)
        {
            try
            {
                rtb_ingresar.Text += "2";
            }
            catch (Exception ex)
            {
                throw new Exception("Error calculadora metodo click boton 2" + ex);
            }
        }
        private void Click_Boton3(object sender, EventArgs e)
        {
            try
            {
                rtb_ingresar.Text += "3";
            }
            catch (Exception ex)
            {
                throw new Exception("Error calculadora metodo click boton 3" + ex);
            }
        }
        private void Click_Boton4(object sender, EventArgs e)
        {
            try
            {
                rtb_ingresar.Text += "4";
            }
            catch (Exception ex)
            {
                throw new Exception("Error calculadora metodo click boton 4" + ex);
            }
        }
        private void Click_Boton5(object sender, EventArgs e)
        {
            try
            {
                rtb_ingresar.Text += "5";
            }
            catch (Exception ex)
            {
                throw new Exception("Error calculadora metodo click boton 5" + ex);
            }
        }
        private void Click_Boton6(object sender, EventArgs e)
        {
            try
            {
                rtb_ingresar.Text += "6";
            }
            catch (Exception ex)
            {
                throw new Exception("Error calculadora metodo click boton 6" + ex);
            }
        }
        private void Click_Boton7(object sender, EventArgs e)
        {
            try
            {
                rtb_ingresar.Text += "7";
            }
            catch (Exception ex)
            {
                throw new Exception("Error calculadora metodo click boton 7" + ex);
            }
        }
        private void Click_Boton8(object sender, EventArgs e)
        {
            try
            {
                rtb_ingresar.Text += "8";
            }
            catch (Exception ex)
            {
                throw new Exception("Error calculadora metodo click boton 8" + ex);
            }
        }
        private void Click_Boton9(object sender, EventArgs e)
        {
            try
            {
                rtb_ingresar.Text += "9";
            }
            catch (Exception ex)
            {
                throw new Exception("Error calculadora metodo click boton 9" + ex);
            }
        }
        private void Click_Boton0(object sender, EventArgs e)
        {
            try
            {
                rtb_ingresar.Text += "0";
            }
            catch (Exception ex)
            {
                throw new Exception("Error calculadora metodo click boton 0" + ex);
            }
        }
        //FRACCION
        public void Click_Boton_Separacion(object sender, EventArgs e)
        {
            try
            {
                if(!fraccion_control)
                {
                    rtb_ingresar.Text += fraccion;
                    fraccion_control = true;
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error calculadora metodo click boton separacion" + ex);
            }
        }
        //BOTONES OPERACIONES
        private void Click_Suma(object sender, EventArgs e)
        {
            try
            {
                operacion = Operacion.Suma;
            }
            catch(Exception ex)
            {
                throw new Exception("Error calculadora metodo click suma" + ex);
            }
        }
        private void Click_Resta(object sender, EventArgs e)
        {
            try
            {
                operacion = Operacion.Resta;
            }
            catch (Exception ex)
            {
                throw new Exception("Error calculadora metodo click resta" + ex);
            }
        }
        private void Click_Multiplicacion(object sender, EventArgs e)
        {
            try
            {
                operacion = Operacion.Multiplicacion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error calculadora metodo Click_Multiplicacion" + ex);
            }
        }

        private void Click_Division(object sender, EventArgs e)
        {
            try
            {
                operacion = Operacion.Division;
            }
            catch (Exception ex)
            {
                throw new Exception("Error calculadora metodo Click_Division" + ex);
            }
        }

        private void Click_Elevar(object sender, EventArgs e)
        {
            try
            {
                operacion = Operacion.Elevar;
            }
            catch (Exception ex)
            {
                throw new Exception("Error calculadora metodo Click_Elevar" + ex);
            }
        }

        private void Click_Raiz(object sender, EventArgs e)
        {
            try
            {
                operacion = Operacion.Raiz;
            }
            catch (Exception ex)
            {
                throw new Exception("Error calculadora metodo Click_Raiz" + ex);
            }
        }
        private void Click_Porcentaje(object sender, EventArgs e)
        {
            try
            {
                operacion = Operacion.Porcentaje;
            }
            catch (Exception ex)
            {
                throw new Exception("Error calculadora metodo Click_Porcentaje" + ex);
            }
        }
        private void Click_Derivacion(object sender, EventArgs e)
        {
            try
            {
                operacion = Operacion.Derivacion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error calculadora metodo Click_Derivacion" + ex);
            }
        }

        private void Click_Integracion(object sender, EventArgs e)
        { 
            try
            {
                operacion = Operacion.Integracion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error calculadora metodo Click_Integracion" + ex);
            }
        }

        private void Click_Boton_Resultado(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception("Error calculadora metodo Click_Boton_Resultado" + ex);
            }
        }
    }
}
