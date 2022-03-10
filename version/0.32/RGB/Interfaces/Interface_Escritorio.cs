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

namespace RGB.Interfaces
{
    public partial class Interface_Escritorio : Form
    {
        private List<Program> l_programas;
        public Interface_Escritorio()
        {
            InitializeComponent();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            try
            {
                toolTip1.Show("Water_Lemur; SoftWorks®", label1);
            }
            catch (Exception ex) { throw new Exception("Error metodo label1_MouseHover " + ex); }
        }

        private void Interface_Escritorio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Interface_Prog_Calculadora interface_calculadora = new Interface_Prog_Calculadora();
            this.Hide();
            interface_calculadora.ShowDialog();
        }
    }
}
