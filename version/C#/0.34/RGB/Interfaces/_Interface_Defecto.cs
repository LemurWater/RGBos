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
    public partial class _Interface_Defecto : Form
    {
        public _Interface_Defecto()
        {
            InitializeComponent();
        }

        public _Interface_Defecto(short id, bool visibilidad, string nombre)
        {
            Id = id;
            Visibilidad = visibilidad;
            Nombre = nombre;
        }

        //Atributos
        private short id;
        private bool visibilidad;
        private string nombre;

        public short Id { get => id; set => id = value; }
        public bool Visibilidad { get => visibilidad; set => visibilidad = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        //Metodos
        //Basico
        public bool Ocultar()
        {
            try
            {
                Hide();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error Clase _Interface_Defecto - Metodo: Ocultar()" + ex);
            }
        }
        public bool Mostrar()
        {
            try
            {
                ShowDialog();
                v
            }
            catch (Exception ex)
            {
                throw new Exception("Error Clase _Interface_Defecto - Metodo: Ocultar()" + ex);
            }
        }
        //Obtener
        public short Obtener_Id()
        {
            try
            {
                return Id;
            }
            catch (Exception ex)
            {
                throw new Exception("Error Clase _Interface_Defecto - Metodo: Objeter_Id" + ex);
            }
        }
        public bool Obtener_Visibilidad()
        {
            try
            {
                return Visibilidad;
            }
            catch (Exception ex)
            {
                throw new Exception("Error Clase _Interface_Defecto - Metodo: Objeter_Visibilidad" + ex);
            }
        }
        public string Obtener_Nombre()
        {
            try
            {
                return Nombre;
            }
            catch (Exception ex)
            {
                throw new Exception("Error Clase _Interface_Defecto - Metodo: Objeter_Nombre" + ex);
            }
        }
        //Cambiar
        public bool Cambiar_Nombre(string nuevo_nombre)
        {
            try
            {
                Nombre = nuevo_nombre;
                label_nombre.Text = nuevo_nombre;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error Clase _Interface_Defecto - Metodo: Cambiar_Nombre(string)" + ex);
            }

        }
    }
}
