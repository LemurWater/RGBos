using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB.ClasesSistema.Usuarios
{
    public static class Caracteres_Avatar
    {
        //Atributos
        private static List<char> l_avatares = new List<char>();

        //Accesores
        public static List<char> L_avatares { get => l_avatares; set => l_avatares = value; }

        //Metodos
        public static bool Iniciar()// 뮤, 봇, 모, 수, 호, 흠, 후, 부, 푸, 흑, 믕, 흥
        {
            try
            {
                L_avatares.Add('뮤');
                L_avatares.Add('봇');
                L_avatares.Add('모');
                L_avatares.Add('수');
                L_avatares.Add('호');
                L_avatares.Add('흠');
                L_avatares.Add('후');
                L_avatares.Add('부');
                L_avatares.Add('푸');
                L_avatares.Add('흑');
                L_avatares.Add('믕');
                L_avatares.Add('흥');

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error Clase: Caracteres_Avatar - Metodo: bool Iniciar()" + ex);
            }
        }
        public static bool Agregar_Avatar(char caracter)
        {
            try
            {
                switch(L_avatares.Contains(caracter))
                {
                    case true:
                        return false;

                    case false:
                        L_avatares.Add(caracter); 
                        return true;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error Clase: Caracteres_Avatar - Metodo: bool Agregar_Avatar(char)" + ex);
            }
        }

        
    }
}
