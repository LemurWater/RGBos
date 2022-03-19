using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace RGB.ClasesSistema.Usuarios
{
    public class Avatar
    {
        private enum enum_Chars { 뮤, 봇, 모, 수, 호 };



        private char caracter = '뮤';

        private Color color_caracter; // Random
        private Color color_marco;
        private Color color_fondo;

        private ConsoleColor cons_color_caracter;
        private ConsoleColor cons_color_fondo;


        public Avatar()
        {
            Random tmp_rnd = new Random();

            byte car = (byte)tmp_rnd.Next(1, 4);
            byte fon = (byte)tmp_rnd.Next(1, 3);


            switch (car)
            {
                case 1:
                    color_caracter = Color.Red;
                    switch (fon)
                    {
                        case 1:
                            color_fondo = Color.Green;
                            color_marco = Color.Blue;
                            return;

                        case 2:
                            color_fondo = Color.Blue;
                            color_marco = Color.Green;
                            return;
                    }
                    return;

                case 2:
                    color_caracter = Color.Green;
                    switch (fon)
                    {
                        case 1:
                            color_fondo = Color.Red;
                            color_marco = Color.Blue;
                            return;

                        case 2:
                            color_fondo = Color.Blue;
                            color_marco = Color.Red;
                            return;
                    }
                    return;

                case 3:
                    color_caracter = Color.Blue;
                    switch (fon)
                    {
                        case 1:
                            color_fondo = Color.Red;
                            color_marco = Color.Green;
                            return;

                        case 2:
                            color_fondo = Color.Green;
                            color_marco = Color.Red;
                            return;
                    }
                    return;
            }
        }
        public Avatar(Color color_caracter, Color color_marco, Color color_fondo, ConsoleColor color_caracter_con)
        {
            Color_caracter = color_caracter;
            Color_marco = color_marco;
            Color_fondo = color_fondo;

            Color_caracter_con = color_caracter_con;
        }


        public char Caracter
        {
            get
            {
                return caracter;
            }
            set
            {
                if (char.IsWhiteSpace(value) || !char.IsDigit(value) || char.IsPunctuation(value))
                {
                    throw new Exception("El caracter ingresado no es valido");
                }
                else if (value == 'A' || value == 'B')
                {
                    throw new Exception("No se permiten caracteres Romanizados");
                }
                else
                {
                    caracter = value;
                    Program.Mensaje_Del_Sistema("Imagen cambiada: " + value);
                }
            }
        }
        public Color Color_caracter
        {
            get
            {
                return color_caracter;
            }
            set
            {
                if (value == color_fondo)
                {
                    throw new Exception("El color del caracter es igual al color del fondo: " + value);
                }
                else color_caracter = value;
            }
        }
        public Color Color_fondo
        {
            get
            {
                return color_fondo;
            }
            set
            {
                if (value == color_caracter)
                {
                    throw new Exception("El color de fondo es igual al color del caracter: " + value);
                }
                else if (value == color_marco)
                {
                    throw new Exception("El color de fondo es igual al color del marco: " + value);
                }
                else color_fondo = value;
            }
        }
        public Color Color_marco
        {
            get
            {
                return color_marco;
            }
            set
            {
                if (value == color_fondo)
                {
                    throw new Exception("El color del marco es igual al color del fondo: " + value);
                }
                else color_marco = value;
            }
        }
        public ConsoleColor Color_caracter_con
        {
            get
            {
                return cons_color_caracter;
            }
            set
            {
                if (value == cons_color_caracter)
                {
                    throw new Exception("El color del caracter (avatar) es el mismo del anterior");
                }
                else cons_color_caracter = value;
            }
        }
        public ConsoleColor Color_fondo_con
        {
            get
            {
                return cons_color_fondo;
            }
            set
            {
                if (value == cons_color_fondo)
                {
                    throw new Exception("El color del fondo (avatar) es el mismo del anterior");
                }
                else cons_color_fondo = value;
            }
        }
    }
}
