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
    public partial class Interface_Prog_Calculadora : Form // TEST
    {
        //Atributos
        public string version = "0.1";


        public char fraccion = '.';          // , . 
        private bool fraccion_control = false;

        private double resultado;

        private List<double> memoria = new List<double>();

        private bool valor_ab = true;

        public Programa_Calculadora calculadora;

        //Constructores
        public Interface_Prog_Calculadora()
        {
            InitializeComponent();

            label_version.Text = "version " + version; 
        }

        //Accesores
        public double Resultado { get => resultado; set => resultado = value; }
        public List<double> Memoria { get => memoria; set => memoria = value; }

        //Metodos
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

                rtb_ingresar.Text += '1';
                switch(valor_ab)
                {
                    case true:
                        calculadora.Cambiar_Valor_A('1');
                        return;

                    case false:
                        calculadora.Cambiar_Valor_B('1');
                        return;
                }
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
                rtb_ingresar.Text += '2';
                switch (valor_ab)
                {
                    case true:
                        calculadora.Cambiar_Valor_A('2');
                        return;

                    case false:
                        calculadora.Cambiar_Valor_B('2');
                        return;
                }
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
                rtb_ingresar.Text += '3';
                switch (valor_ab)
                {
                    case true:
                        calculadora.Cambiar_Valor_A('3');
                        return;

                    case false:
                        calculadora.Cambiar_Valor_B('3');
                        return;
                }
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
                rtb_ingresar.Text += '4';
                switch (valor_ab)
                {
                    case true:
                        calculadora.Cambiar_Valor_A('4');
                        return;

                    case false:
                        calculadora.Cambiar_Valor_B('4');
                        return;
                }
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
                rtb_ingresar.Text += '5';
                switch (valor_ab)
                {
                    case true:
                        calculadora.Cambiar_Valor_A('5');
                        return;

                    case false:
                        calculadora.Cambiar_Valor_B('5');
                        return;
                }
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
                rtb_ingresar.Text += '6';
                switch (valor_ab)
                {
                    case true:
                        calculadora.Cambiar_Valor_A('6');
                        return;

                    case false:
                        calculadora.Cambiar_Valor_B('6');
                        return;
                }
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
                rtb_ingresar.Text += '7';
                switch (valor_ab)
                {
                    case true:
                        calculadora.Cambiar_Valor_A('7');
                        return;

                    case false:
                        calculadora.Cambiar_Valor_B('7');
                        return;
                }
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
                rtb_ingresar.Text += '8';
                switch (valor_ab)
                {
                    case true:
                        calculadora.Cambiar_Valor_A('8');
                        return;

                    case false:
                        calculadora.Cambiar_Valor_B('8');
                        return;
                }
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
                rtb_ingresar.Text += '9';
                switch (valor_ab)
                {
                    case true:
                        calculadora.Cambiar_Valor_A('9');
                        return;

                    case false:
                        calculadora.Cambiar_Valor_B('9');
                        return;
                }
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
                rtb_ingresar.Text += '0';
                switch (valor_ab)
                {
                    case true:
                        calculadora.Cambiar_Valor_A('0');
                        return;

                    case false:
                        calculadora.Cambiar_Valor_B('0');
                        return;
                }
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
                    switch (valor_ab)
                    {
                        case true:
                            calculadora.Cambiar_Valor_A(fraccion);
                            return;

                        case false:
                            calculadora.Cambiar_Valor_B(fraccion);
                            return;
                    }
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
        private void Defecto_Boton_Operacion()
        {
            valor_ab = false;
            rtb_ingresar.Clear();
        }
        //
        private void Click_Suma(object sender, EventArgs e)
        {
            try
            {
                Defecto_Boton_Operacion();
                calculadora.Cambiar_Operacion(Enum_Operacion.Suma);
                Console.WriteLine(" Suma"); // TEST
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
                Defecto_Boton_Operacion();
                calculadora.Operacion = Enum_Operacion.Resta;
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
                Defecto_Boton_Operacion();
                calculadora.Operacion = Enum_Operacion.Multiplicacion;
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
                Defecto_Boton_Operacion();
                calculadora.Operacion = Enum_Operacion.Division;
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
                Defecto_Boton_Operacion();
                calculadora.Operacion = Enum_Operacion.Elevar;
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
                Defecto_Boton_Operacion();
                calculadora.Operacion = Enum_Operacion.Raiz;
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
                Defecto_Boton_Operacion();
                calculadora.Operacion = Enum_Operacion.Porcentaje;
            }
            catch (Exception ex)
            {
                throw new Exception("Error calculadora metodo Click_Porcentaje" + ex);
            }
        }
        //
        private void Click_Derivacion(object sender, EventArgs e)
        {
            try
            {
                Defecto_Boton_Operacion();
                calculadora.Operacion = Enum_Operacion.Derivacion;
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
                Defecto_Boton_Operacion();
                calculadora.Operacion = Enum_Operacion.Integracion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error calculadora metodo Click_Integracion" + ex);
            }
        }
        //
        private void Defecto_Boton_Resultado()
        {
            Console.Write(" " + calculadora.Obtener_Valor_A());
            Console.Write(" [?] ");
            Console.WriteLine(calculadora.Obtener_Valor_B());
        }
        private void Click_Boton_Resultado(object sender, EventArgs e)
        {
            try
            {
                Defecto_Boton_Resultado();

                switch (calculadora.Obtener_Operacion())
                {
                    default:
                        throw new Exception("No se selecciono ninguna operacion");

                    case Enum_Operacion.Suma:
                        rtb_ingresar.Text = (calculadora.Sumar(calculadora.Obtener_Valor_A(), calculadora.Obtener_Valor_B())).ToString();
                        rtb_historial.Text = calculadora.Obtener_Ultima_Memoria()[0].ToString() + " - " + calculadora.Obtener_Ultima_Memoria()[1].ToString();


                        Console.WriteLine(" = " + rtb_ingresar.Text);
                        return;

                    case Enum_Operacion.Resta:
                        rtb_ingresar.Text = (calculadora.Restar(calculadora.Obtener_Valor_A(), calculadora.Obtener_Valor_B())).ToString();
                        return;

                    case Enum_Operacion.Multiplicacion:
                        rtb_ingresar.Text = (calculadora.Multiplicar(calculadora.Obtener_Valor_A(), calculadora.Obtener_Valor_B())).ToString();
                        return;

                    case Enum_Operacion.Division:
                        rtb_ingresar.Text = (calculadora.Dividir(calculadora.Obtener_Valor_A(), calculadora.Obtener_Valor_B())).ToString();
                        return;

                    case Enum_Operacion.Raiz:
                        rtb_ingresar.Text = (calculadora.Radicar(calculadora.Obtener_Valor_A(), calculadora.Obtener_Valor_B())).ToString();
                        return;

                    case Enum_Operacion.Residuo:
                        rtb_ingresar.Text = (calculadora.Residuar(calculadora.Obtener_Valor_A(), calculadora.Obtener_Valor_B())).ToString();
                        return;

                    case Enum_Operacion.Porcentaje:
                        rtb_ingresar.Text = (calculadora.Porcentuar(calculadora.Obtener_Valor_A(), calculadora.Obtener_Valor_B())).ToString();
                        return;

                    case Enum_Operacion.Elevar:
                        rtb_ingresar.Text = (calculadora.Potenciar(calculadora.Obtener_Valor_A(), calculadora.Obtener_Valor_B())).ToString();
                        return;

                    case Enum_Operacion.Derivacion:
                        rtb_ingresar.Text = (calculadora.Derivar("Falta")).ToString();
                        return;

                    case Enum_Operacion.Integracion:
                        rtb_ingresar.Text = (calculadora.Integrar("Falta")).ToString();
                        return;                   
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error calculadora metodo Click_Boton_Resultado" + ex);
            }
        }


    }
}
