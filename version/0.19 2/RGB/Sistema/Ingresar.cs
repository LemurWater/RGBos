using RGB.Clases;
using RGB.Interfaces;
using System;

namespace RGB.Sistema
{
    public class Ingresar
    {
        Interface_Acceso form_acceso = new Interface_Acceso();
        bool crear_acceso = true;

        private bool tmp_bandera;
        private string tmp_clave;
        private byte tmp_intentos = 0;



        public void Correr()
        {
            if (Program.l_usuarios.Count == 0)
            {
                do
                {
                    tmp_bandera = Nuevo_Usuario();

                } while (!tmp_bandera);

                Acceder_Usuario();
            }
            else
            {
                Acceder_Usuario();
            }
        }

        public bool Nuevo_Usuario()
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
        public void Acceder_Usuario()
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
                for (int i = 0; i < eleccion; i++)
                {
                    Ingresar.tmp_clave = Program.l_usuarios[i + 1].Clave;
                }
                Preguntar_Clave(eleccion);
            }
            catch (Exception ex)
            {
                throw new Exception("Error metodo acceder_usuario " + ex);
            }
        }

        public void Preguntar_Clave(byte eleccion)
        {
            //Preguntar Clave
            if (tmp_intentos >= Program.l_usuarios[0].Bloqueo_intentos)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nIngrese la clave para " + Program.l_usuarios[eleccion].Nombre);

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                if (Console.ReadLine() != Program.l_usuarios[eleccion].Clave)
                {
                    Clave_Invalida();
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

       public void Clave_Invalida()
        {
            tmp_intentos++;
            Console.WriteLine("\nError! La clave no es correcta - INTENTO: " + tmp_intentos + "/" + Program.l_usuarios[0].Bloqueo_intentos);
        }


    }
}
