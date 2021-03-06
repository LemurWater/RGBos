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

namespace RGB
{
    class Program
    {

        static string[] test = { "aaaaaaaaaaaaaa", "bbbbbbbbbbbbbb" };
        static char char_marco = '█';

        static Exception exception;

        string[] txt_esp = { "Ingrese el nombre del nuevo usuario", "Ingrese la contrasena" };
        string[] txt_ing = { "Enter a name for the new user", "Create new password" };
        string[] txt_kor;
        public static List<Usuario> l_usuarios = new List<Usuario>();
        static public byte tamano_x = 80, tamano_y = 28;
        public static string tmp_clave;


        static void Main(string[] args)
        {
            try
            {
                Inicio02.Imprimir();



                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
                Console.Clear();

                Console.SetWindowSize(tamano_x, tamano_y);

                //public Idioma idioma = Idioma.Espanol;
                //public enum Idiomaa { Espanol, Ingles, Coreano };
                //public Idiomaa idioma;

                // Console.WriteLine("\nRGB Ver 0.1a");


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
                Console.Write(" - Ver 0.4a");
                Console.WriteLine(" - - - - - - - - -\n");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                if (l_usuarios.Count == 0)
                {
                    Usuario nuevo_usuario = new Usuario(000001, "RGB", "RGB", DateTime.Now, DateTime.Now, 5, 0);

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Ingrese el nombre del nuevo usuario");

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    nuevo_usuario.nombre = Console.ReadLine();

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nIngrese la contrasena");

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    nuevo_usuario.clave = Console.ReadLine();

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nVuelva a ingresar la contrasena");

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    tmp_clave = Console.ReadLine();
                    if (nuevo_usuario.clave != tmp_clave)
                    {
                        Console.WriteLine("\nError! Las contrasenas no son iguales!");
                    }
                    else
                    {
                        l_usuarios.Add(nuevo_usuario);

                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n*  Usuario creado");


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

        static void acceder_usuario()
        {
            try
            {
                Interface_Default form_interface = new Interface_Default();
                Application.Run(form_interface);
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
                    Console.WriteLine("#" + contador + " - " + u.nombre);
                }

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                byte.TryParse(Console.ReadLine(), out byte eleccion);
                for (int i = 0; i < eleccion; i++)
                {
                    tmp_clave = l_usuarios[i + 1].clave;
                }
                //Preguntar Clave
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nIngrese la clave para " + l_usuarios[eleccion].nombre);

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                if (Console.ReadLine() != l_usuarios[eleccion].clave)
                {
                    Console.WriteLine("\nError! La clave no es correcta");
                    byte bloqueo_contador = 1;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;

                    Console.WriteLine("\nBienvenido " + l_usuarios[eleccion].nombre + "    -    Fecha actual:  " + DateTime.Now.ToString());

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }
            catch (Exception ex)
            {
                
            }
        }



        
        private void guardar_acciones(string texto)
        {

        }
        static void Marco(string linea)
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