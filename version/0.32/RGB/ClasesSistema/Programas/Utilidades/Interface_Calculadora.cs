using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RGB.ClasesSistema.Programas.Utilidades;

namespace RGB.ClasesSistema.Programas.Utilidades //✓✓✓☑✓✓✓☑    ☒✗✘
{
    public partial class Interface_Calculadora : Form
    {
        //Atributos

        public string version = "0.1";


        public char fraccion = '.';          // , . 
        private bool fraccion_control = false;

        private double valor_a;
        private double valor_b;
        private double resultado;

        private List<double> memoria = new List<double>();


        public Interface_Calculadora()
        {
            InitializeComponent();

            label_version.Text = "version " + version; 
        }

        public Interface_Calculadora(double valor_a, double valor_b, double resultado, List<double> memoria)
        {
            Valor_a = valor_a;
            Valor_b = valor_b;
            Resultado = resultado;
            Memoria = memoria;
        }


        public double Valor_a
        {
            get
            {
                return valor_a;
            }
            set
            {
                valor_a = value;
            }
        }
        public double Valor_b { get => valor_b; set => valor_b = value; }
        public double Resultado { get => resultado; set => resultado = value; }
        public List<double> Memoria { get => memoria; set => memoria = value; }


        private void Interface_Calculadora_Load(object sender, EventArgs e)
        {
            rtb_ingresar.NumberUpDown(true);
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
                if(double.TryParse(rtb_ingresar.Text, out double result))
                {
                    Programa_Calculadora.Cambiar_Operacion(Programa_Calculadora.Enum_Operacion.Suma);
                    Programa_Calculadora.Cambiar_Valor_A(valor_a);
                }
                else
                {
                    throw new Exception("El numero ingresado no es valido");
                }


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
                Programa_Calculadora.Operacion = Programa_Calculadora.Enum_Operacion.Resta;
                Programa_Calculadora.Valor_a = valor_a;
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
                Programa_Calculadora.Operacion = Programa_Calculadora.Enum_Operacion.Multiplicacion;
                Programa_Calculadora.Valor_a = valor_a;
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
                Programa_Calculadora.Operacion = Programa_Calculadora.Enum_Operacion.Division;
                Programa_Calculadora.Valor_a = valor_a;
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
                Programa_Calculadora.Operacion = Programa_Calculadora.Enum_Operacion.Elevar;
                Programa_Calculadora.Valor_a = valor_a;
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
                Programa_Calculadora.Operacion = Programa_Calculadora.Enum_Operacion.Raiz;
                Programa_Calculadora.Valor_a = valor_a;
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
                Programa_Calculadora.Operacion = Programa_Calculadora.Enum_Operacion.Porcentaje;
                Programa_Calculadora.Valor_a = valor_a;
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
                Programa_Calculadora.Operacion = Programa_Calculadora.Enum_Operacion.Derivacion;
                Programa_Calculadora.Valor_a = valor_a;
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
                Programa_Calculadora.Operacion = Programa_Calculadora.Enum_Operacion.Integracion;
                Programa_Calculadora.Valor_a = valor_a;
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
                switch (operacion)
                {
                    case Operacion.Suma:
                        resultado = Programa_Calculadora.Sumar(valor_a, valor_b);
                        return;

                    case Operacion.Resta:
                        resultado = Programa_Calculadora.Restar(valor_a, valor_b);
                        return;

                    case Operacion.Multiplicacion:
                        resultado = Programa_Calculadora.Multiplicar(valor_a, valor_b);
                        return;

                    case Operacion.Division:
                        resultado = Programa_Calculadora.Dividir(valor_a, valor_b);
                        return;

                    case Operacion.Raiz:
                       
                        return;

                    case Operacion.Residuo:
                        resultado = Programa_Calculadora.Residuo(valor_a, valor_b);
                        return;

                    case Operacion.Porcentaje:
                        resultado = Programa_Calculadora.Porcentaje(valor_a, valor_b);
                        return;

                    case Operacion.Integracion:
                        resultado = Programa_Calculadora.Integra(valor_a, valor_b);
                        return;

                    case Operacion.Elevar:
                        return;

                    default:
                        throw new Exception("No se selecciono operaciones");
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error calculadora metodo Click_Boton_Resultado" + ex);
            }
        }
    }
}
