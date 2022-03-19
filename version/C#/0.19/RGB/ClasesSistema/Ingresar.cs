using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RGB.Clases;
using RGB.Interfaces;
using RGB.ClasesSistema.Usuarios;
using RGB.ClasesSistema;

namespace RGB.ClasesSistema
{
    public class Ingresar
    {
        //Atributos
        Interface_Acceso form_acceso = new Interface_Acceso();
        bool crear_acceso = true;

        static Usuario usuario;


        //Control
        private bool tmp_bandera;
        private string tmp_clave;
        private byte tmp_intentos = 0;


        //Metodos
        public bool Nuevo_Usuario()
        {
            try
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
                    return false;
                }
                else
                {
                    Program.l_usuarios.Add(nuevo_usuario);

                    Program.Mensaje_Del_Sistema("Usuario creado");
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error METODO: Nuevo_Usuario() - " + ex);
            }        
        }

        public byte Buscar_Usuario()
        {
            try
            {
                Program.Mensaje_Del_Sistema("Acceso");

                //Forms
                if (crear_acceso)
                {
                    form_acceso.ShowDialog(); //Application.Run(form_acceso);
                    crear_acceso = false;
                }

                // Acceder
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nSeleccione usuario (Nombre)");
                byte contador = 1;

                foreach (Usuario u in Program.l_usuarios)
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("#" + contador + " - " + u.Nombre);
                }

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                byte.TryParse(Console.ReadLine(), out byte eleccion);

                return eleccion;
            }

            catch (Exception ex)
            {
                throw new Exception("Error metodo acceder_usuario " + ex);
            }
        }

        public void Ingresar_Usuario(byte cantidad_usuarios)
        {
            switch (cantidad_usuarios)
            {
                case 0:
                    Nuevo_Usuario();
                    return;

                default:
                    Buscar_Usuario();
                    return;
            }
        }

        public void Preguntar_Clave(byte eleccion, byte maximo_intentos, string nombre)
        {
            try
            {
            //goto
            reintentar:
                {
                    //Preguntar Clave
                    if (tmp_intentos < maximo_intentos)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\nIngrese la clave para " + nombre);

                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        if (Console.ReadLine() != Program.l_usuarios[eleccion].Clave)
                        {
                            Console.WriteLine("\nError! La clave no es correcta. INTENTO " + tmp_intentos + "/" + maximo_intentos);
                            tmp_intentos++;


                            goto reintentar;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.DarkYellow;

                            Console.WriteLine("\nBienvenido " + Program.l_usuarios[eleccion].Nombre + "    -    Fecha actual:  " + DateTime.Now.ToString());

                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error METODO: Preguntar_Clave()" + ex);
            }

        }

    }
}
