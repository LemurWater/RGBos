using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;



namespace ArchivosBitMap.Forms
{
    public partial class LeerBmp : Form
    {

        public static string nombreArchivo = "RGBos®_Archivo_Plantilla_RGB_02";
        public string direccion = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory().ToString()).ToString().ToString()).ToString()
            + @"\Archivos\"
            + nombreArchivo
            + ".bmp";


        public LeerBmp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap archivo_de_imagen = new Bitmap(direccion, true);

                pictureBox2.Image = archivo_de_imagen;

                label1.Text = "Formato de pixel: " + archivo_de_imagen.PixelFormat.ToString();

                label2.Text = "Linea 1: " + archivo_de_imagen.GetPixel(0, 0).ToString();
                label3.Text = "Linea 2: " + archivo_de_imagen.GetPixel(0, 1).ToString();
                label4.Text = "Linea 3: " + archivo_de_imagen.GetPixel(0, 2).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error buscando la direccion del archivo.");
            }
        }
    }
}
