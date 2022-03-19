using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using RGB.Interfaces;
using System.Windows.Forms;

using RGB.ClasesSistema;
using RGB.ClasesSistema.Usuarios;
using RGB.ClasesSistema.Programas.Utilidades;


namespace RGB
{
    internal class Program
    {
        //Enums
        public enum Tipo_Mensaje { Sistema, Error, Acciones, Resaltado, Normal };

        //Sistema
        public static Sistema sistema = new Sistema(); 

        public static Ingreso ingresar = new Ingreso();
   

        public static List<Usuario> l_usuarios = new List<Usuario>();
        //Control
        static string version = "Ver 0.17g";


        static string[] test = { "aaaaaaaaaaaaaa", "bbbbbbbbbbbbbb" };
        static char char_marco = '█';

        string[] txt_esp = { "Ingrese el nombre del nuevo usuario", "Ingrese la contrasena" };
        string[] txt_ing = { "Enter a name for the new user", "Create new password" };
        string[] txt_kor;

        static public byte tamano_x = 80, tamano_y = 28;


        //Forms
        static Interface_Nuevo_Usuario form_n_usuario = new Interface_Nuevo_Usuario();
        static bool crear_n_usuario = true;

        static void Main(string[] args)
        {
            try
            {
                //Pantalla de inicio (Consola)






                //Inicio.Imprimir();
                //RGB.Prueba.Prueba_Juego prueba_juego = new RGB.Prueba.Prueba_Juego();
                Interface_Calculadora prueba_juego = new Interface_Calculadora();
                RGB.ClasesSistema.Programas.Utilidades.Interface_Prog_Texto probar_p_texto = 
                    new RGB.ClasesSistema.Programas.Utilidades.Interface_Prog_Texto();
                prueba_juego.ShowDialog();






                Console.SetWindowSize(tamano_x, tamano_y);

                //public Idioma idioma = Idioma.Espanol;
                //public enum Idiomaa { Espanol, Ingles, Coreano };
                //public Idiomaa idioma;

                Version();

                //ingresar.Correrr();
                ingresar.Ingresar_Usuario(sistema.Cantidad_Usuarios());

                Console.ReadLine();
                Marco(test);

                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception("Error CLASE Programa - METODO Main" + e);
            }
        }
        //

        private void guardar_acciones(string texto)
        {

        }

        private static void Version()
        {
            try
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(" ");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("R");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("G");
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write("B");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(" - " + version);
                Console.WriteLine(" - - - - - - - - -\n");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch(Exception ex)
            {
                throw new Exception("Error CLASE Programa - METODO Versis() + " + ex);
            }
        }
        public static void Mensaje_Del_Sistema(string texto)
        {
            try
            {
                ConsoleColor tmp_fondo = Console.BackgroundColor;
                ConsoleColor tmp_texto = Console.ForegroundColor;

                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.ForegroundColor = ConsoleColor.White;


                Console.WriteLine("\n*   " + texto + "                 " + DateTime.Now + "\n");


                Console.BackgroundColor = tmp_fondo;
                Console.ForegroundColor = tmp_texto;
            }
            catch(Exception ex)
            {
                throw new Exception("Error CLASE Programa - METODO Mensaje_Del_Sistema(string) + " + ex);
            }
        }

        public static void Mensaje_Del_Sistema(Tipo_Mensaje tipo_mensaje, string texto)
        {
            try
            {
                switch (tipo_mensaje)
                {
                    case Tipo_Mensaje.Sistema:
                        return;

                    case Tipo_Mensaje.Error:
                        return;

                    case Tipo_Mensaje.Acciones:
                        return;

                    case Tipo_Mensaje.Resaltado:
                        return;

                    case Tipo_Mensaje.Normal:
                        return;
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Error CLASE Programa - METODO Mensaje_Del_Sistema(Tipo_Mensaje) + " + ex);
            }

        }

        static void Marco(string linea)
        {
            try
            {
                //Texto
                byte relleno = (byte)(linea.Length - 4);
                string espacio = "";
                for (byte i = 0; i < (tamano_x - 8 - relleno); i++)
                {
                    espacio += " ";
                }
                Console.Write(char_marco + " " + linea + espacio + " " + char_marco + "\n");
            }
            catch (Exception ex)
            {
                throw new Exception("Error CLASE Programa - METODO Marco(string) " + ex);
            }
        }
        static void Marco(string[] lineas) // █▓▒░
        {
            try
            {
                //Primera linea
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Black;

                Console.Clear();

                for (byte i = 0; i < tamano_x; i++)
                {
                    Console.Write(char_marco);
                }
                Console.WriteLine();
                foreach (string lineaa in lineas)
                {
                    Marco(lineaa);
                }
                //Ultima linea
                for (byte i = 0; i < tamano_x; i++)
                {
                    Console.Write(char_marco);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error en el metodo Marco - " + e);
            }
        }

        public static byte Cantidad_Intentos()
        {
            try
            {
                return sistema.usuario_activo.Bloqueo_intentos;
            }
            catch(Exception ex)
            {
                throw new Exception("Error CLASE Programa - METODO Cantidad_Intentos() + " + ex);
            }
        }

    }
}