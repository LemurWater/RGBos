using System;
using System.Drawing;
using System.Windows.Forms;

namespace RGB.ClasesSistema.Programas.Utilidades
{
    public partial class Interface_Prog_Texto : Form
    {
        //Atributos
        public string version = "0.1";
        
        Color seleccionar_color = Color.Magenta;
        bool primero;
        
        //Constructores
        public Interface_Prog_Texto()
        {
            InitializeComponent();

            label_version.Text = "Version " + version;
        }

        //Metodos
        private void Interface_Prog_Texto_Load(object sender, EventArgs e)
        {

        }
        private void Click_Color_Nuevo(object sender, EventArgs e)
        {
            try
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    seleccionar_color = colorDialog1.Color;
                    color_nuevo.BackColor = seleccionar_color;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("error programa texto metodo color nuevo click" + ex);
            }
        }

        private void Click_Guardar(object sender, EventArgs e)
        {
            try
            {
                rtx_texto.SelectionColor = seleccionar_color;
                if (primero)
                {
                    rtx_texto.SelectedText = rtb_ingresar.Text;
                }
                else
                {
                    rtx_texto.SelectedText = Environment.NewLine + rtb_ingresar.Text;
                }
                primero = false;
                rtb_ingresar.Clear();
                rtb_ingresar.Focus();
            }
            catch (Exception ex)
            {
                throw new Exception("error programa texto metodo guardar " + ex);
            }
        }
    }
}
