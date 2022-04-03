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

namespace BitMapTest
{
    public partial class Form1 : Form
    {
        string path = Directory.GetCurrentDirectory() + @"\Files\";
        //string path2 = @"X:\=Projects GitHub\GitHub\version\C#\ArchivosBMP\Archivos\RGBos®_FileBlueprint_RGB_02.bmp";
        public string nombreArchivo = "RGBos®_FileBlueprint_RGB_02" + ".bmp";
        //public string path2 = Directory.GetCurrentDirectory() + @"\Files\" + "RGBos®_FileBlueprint_RGB_02" + ".bmp";
        //public string path2 = Directory.GetCurrentDirectory(); // + @"\RGBos®_FileBlueprint_RGB_02" + ".bmp"


        //public string path2 = Directory.GetParent(Directory.GetCurrentDirectory().ToString()).ToString().ToString();
        
        
        //public string path2 = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory().ToString()).ToString().ToString()).ToString();
        
        public string path2 = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory().ToString()).ToString().ToString()).ToString() 
            + @"\Files\" + "RGBos®_FileBlueprint_RGB_02" + ".bmp";


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = path2;
            label1.Text = Directory.GetCurrentDirectory().ToString();
            B1();
        }
        void B1()
        {
            try
            {
                //string path2 = @"C:\Users\Alice\Downloads\bitmaptest4\BitMapTest\Files\RGBos®_FileBlueprint_RGB_02 - Copy.bmp";
                //Bitmap image1 = new Bitmap(path + "test.bmp", true);
                Bitmap image1 = new Bitmap(path2, true);

                int x, y;

                /*// Loop through the images pixels to reset color.
                for (x = 0; x < image1.Width; x++)
                {
                    for (y = 0; y < image1.Height; y++)
                    {
                        Color pixelColor = image1.GetPixel(x, y);
                        Color newColor = Color.FromArgb(pixelColor.R, 0, 0);
                        image1.SetPixel(x, y, newColor);
                    }
                }*/

                // Set the PictureBox to display the image.
                pictureBox1.Image = image1;

                // Display the pixel format in Label1.
                label1.Text = "Pixel format: " + image1.PixelFormat.ToString();

                label2.Text = image1.GetPixel(0, 0).ToString();
                label3.Text = image1.GetPixel(0, 1).ToString();
                label4.Text = image1.GetPixel(0, 2).ToString();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("There was an error." +
                    "Check the path to the image file.");
            }
        }

        void B2()
        {
            try
            {
                // Retrieve the image.

                //Bitmap image1 = new Bitmap(path + "test.bmp", true);
                Bitmap image1 = new Bitmap(path2, true);

                int x, y;

                // Loop through the images pixels to reset color.
                for (int i = 0; i < image1.Height; i++)
                {
                    for (int j = 0; j < image1.Width; j++)
                    {
                        Color newColor = Color.Magenta;
                        image1.SetPixel(j, i, newColor);
                    }
                }

                // Set the PictureBox to display the image.
                pictureBox1.Image = image1;

                // Display the pixel format in Label1.
                label1.Text = "Pixel format: " + image1.PixelFormat.ToString();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("There was an error." +
                    "Check the path to the image file.");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            B2();           
        }
    }
}
