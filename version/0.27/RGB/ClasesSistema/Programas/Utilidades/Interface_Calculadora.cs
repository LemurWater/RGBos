using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB.ClasesSistema.Programas.Utilidades
{
    public partial class Interface_Calculadora : Form
    {
        //Atributos
        public enum Operacion { Suma, Resta, Multiplicacion, Division, Residuo, Porcentaje, Elevar, Raiz, Derivacion, Integracion};
        public Operacion operacion;
        public Interface_Calculadora()
        {
            InitializeComponent();
        }

        private void Interface_Calculadora_Load(object sender, EventArgs e)
        {

        }

        //BOTONES NUMEROS
        private void Click_Boton1(object sender, EventArgs e)
        {
            rtb_ingresar.Text += "1";
        }

        //BOTONES OPERACIONES
        private void Click_Suma(object sender, EventArgs e)
        {
            operacion = Operacion.Suma;
        }
        private void Click_Resta(object sender, EventArgs e)
        {
            operacion = Operacion.Resta;
        }
        private void Click_Multiplicacion(object sender, EventArgs e)
        {
            operacion = Operacion.Multiplicacion;
        }

        private void Click_Division(object sender, EventArgs e)
        {
            operacion = Operacion.Division;
        }

        private void Click_Elevar(object sender, EventArgs e)
        {
            operacion = Operacion.Elevar;
        }

        private void Click_Raiz(object sender, EventArgs e)
        {
            operacion = Operacion.Raiz;
        }
        private void Click_Porcentaje(object sender, EventArgs e)
        {
            operacion = Operacion.Porcentaje;
        }
        private void Click_Derivacion(object sender, EventArgs e)
        {
            operacion = Operacion.Derivacion;
        }

        private void Click_Integracion(object sender, EventArgs e)
        {
            operacion = Operacion.Integracion; 
        }

        private void Click_Boton2(object sender, EventArgs e)
        {

        }

        private void Click_Boton3(object sender, EventArgs e)
        {

        }

        private void Click_Boton4(object sender, EventArgs e)
        {

        }

        private void Click_Boton5(object sender, EventArgs e)
        {

        }

        private void Click_Boton6(object sender, EventArgs e)
        {

        }

        private void Click_Boton7(object sender, EventArgs e)
        {

        }

        private void Click_Boton8(object sender, EventArgs e)
        {

        }

        private void Click_Boton9(object sender, EventArgs e)
        {

        }
    }
}
