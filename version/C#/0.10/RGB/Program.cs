using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RGB.Clases;
using RGB.Archivos;

using System.IO;

using RGB.Interfaces;
using System.Windows.Forms;

using RGB.Sistema;


namespace RGB
{
    class Program
    {

        static string[] test = { "aaaaaaaaaaaaaa", "bbbbbbbbbbbbbb" };
        static char char_marco = '█';

        string[] txt_esp = { "Ingrese el nombre del nuevo usuario", "Ingrese la contrasena" };
        string[] txt_ing = { "Enter a name for the new user", "Create new password" };
        string[] txt_kor;
        public static List<Usuario> l_usuarios = new List<Usuario>();
        static public byte tamano_x = 80, tamano_y = 28;
        public static string tmp_clave;


        //Forms
        static Interface_Acceso form_acceso = new Interface_Acceso();
        static Interface_Escritorio form_escritorio = new Interface_Escritorio();
        static Interface_Nuevo_Usuario form_n_usuario = new Interface_Nuevo_Usuario();
        static bool crear_acceso = true;
        static bool crear_escritorio = true;
        static bool crear_n_usuario = true;


        static void Main(string[] args)
        {
            try
            {
                Inicio.Imprimir();



                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
                Console.Clear();

                Console.SetWindowSize(tamano_x, tamano_y);

                //public Idioma idioma = Idioma.Espanol;
                //public enum Idiomaa { Espanol, Ingles, Coreano };
                //public Idiomaa idioma;


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
                Console.Write(" - Ver 0.7a");
                Console.WriteLine(" - - - - - - - - -\n");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                if (l_usuarios.Count == 0)
                {

                     Usuario nuevo_usuario = new Usuario(000001, "RGB", "RGB", DateTime.Now, DateTime.Now, 5, 0, "test_info", "default_test");//000001, "RGB", "RGB", DateTime.Now, DateTime.Now, 5, 0, l_a, "default"

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Ingrese el nombre del nuevo usuario");

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    nuevo_usuario.Nombre = Console.ReadLine();

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nIngrese la contrasena");

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    nuevo_usuario.Clave = Console.ReadLine();

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nVuelva a ingresar la contrasena");

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    tmp_clave = Console.ReadLine();
                    if (nuevo_usuario.Clave != tmp_clave)
                    {
                        Console.WriteLine("\nError! Las contrasenas no son iguales!");
                    }
                    else
                    {
                        l_usuarios.Add(nuevo_usuario);

                        mensaje_del_sistema("Usuario creado");


                        acceder_usuario();


                        Marco(test);

                        Console.ReadLine();
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error en metodo Main" + e);
            }
        }

        public static void mensaje_del_sistema(string texto)
        {
            ConsoleColor tmp_fondo = Console.BackgroundColor ;
            ConsoleColor tmp_texto = Console.ForegroundColor ;

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine("\n*   " + texto + "                 " + DateTime.Now + "\n");


            Console.BackgroundColor = tmp_fondo;
            Console.ForegroundColor = tmp_texto;
        }
        public static void usar_escritorio()
        {
            try
            {
                mensaje_del_sistema("Escritorio");

                if (crear_escritorio)
                {
                    form_escritorio.ShowDialog();
                    crear_escritorio = false;
                }
                //               
            }
            catch (Exception ex)
            {
                throw new Exception("Error metodo usar_escritorio " + ex);
            }
        }
        static void acceder_usuario()
        {
            try
            {
                if(crear_acceso)
                {
                    mensaje_del_sistema("Acceso");
                    Application.Run(form_acceso);
                    crear_acceso = false;                   
                }
                //

                // Acceder
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nSeleccione usuario (Nombre)");
                byte contador = 1;
                foreach (Usuario u in l_usuarios)
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("#" + contador + " - " + u.Nombre);
                }

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                byte.TryParse(Console.ReadLine(), out byte eleccion);
                for (int i = 0; i < eleccion; i++)
                {
                    tmp_clave = l_usuarios[i + 1].Clave;
                }
                //Preguntar Clave
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nIngrese la clave para " + l_usuarios[eleccion].Nombre);

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                if (Console.ReadLine() != l_usuarios[eleccion].Clave)
                {
                    Console.WriteLine("\nError! La clave no es correcta");
                    byte bloqueo_contador = 1;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;

                    Console.WriteLine("\nBienvenido " + l_usuarios[eleccion].Nombre + "    -    Fecha actual:  " + DateTime.Now.ToString());

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error metodo acceder_usuario " + ex);
            }
        }



        
        private void guardar_acciones(string texto)
        {

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
                throw new Exception("Error metodo Marco " + ex);
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
    }
}