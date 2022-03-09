using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB.ClasesSistema.Programas.Utilidades
{
    public static class Programa_Calculadora
    {
        //Enums
        public enum Enum_Operacion { Suma, Resta, Multiplicacion, Division, Residuo, Porcentaje, Elevar, Raiz, Derivacion, Integracion };

        //Atributos
        private static double valor_a;
        private static double valor_b;
        private static double resultado;

        private static List<double> memoria = new List<double>();


       private static Enum_Operacion operacion;

        //Accesores
        public static double Valor_a { get => valor_a; set => valor_a = value; }
        public static double Valor_b { get => valor_b; set => valor_b = value; }
        public static double Resultado { get => resultado; set => resultado = value; }
        public static List<double> Memoria { get => memoria; }
        public static Enum_Operacion Operacion { get => operacion; set => operacion = value; }

        //Metodos
        public static bool Cambiar_Valor_A(double valor)
        {
            try
            {
                Valor_a = valor;
                return true;
            }
            catch(Exception ex)
            {
                return false;
                throw new Exception("Error metodo Prog_Calculadora - Metodo: Cambiar_Valor_A" + ex);
            }
        }
        public static bool Cambiar_Operacion(Enum_Operacion nueva_operacion)
        {
            try
            {
                Operacion = nueva_operacion;
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception("Error metodo Prog_Calculadora - Metodo: Cambiar_Operacion" + ex);
            }
        }
        public static bool Cambiar_Valor_B(double valor)
        {
            try
            {
                Valor_b = valor;
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Error metodo Prog_Calculadora - Metodo: Cambiar_Valor_B" + ex);
            }
        }
        public static double Sumar(double a, double b)
        {
            try
            {
                Resultado = a + b;
                Memoria.Add(Resultado);
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error metodo Prog calc - Metodo Sumar" + ex);
            }
        }
        public static double Restar(double a, double b)
        {
            try
            {
                Resultado = a - b;
                Memoria.Add(Resultado);
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error metodo Prog calc - Metodo Restar" + ex);
            }
        }
        public static double Multiplicar(double a, double b)
        {
            try
            {
                Resultado = a * b;
                Memoria.Add(Resultado);
                return Resultado;
            }
            catch(Exception ex)
            {
                throw new Exception("Error metodo Prog calc - Metodo Restar" + ex);
            }
        }
        public static double Dividir(double a, double b)
        {
            try
            {
                Resultado = a / b;
                Memoria.Add(Resultado);
                return Resultado;
            }
            catch(Exception ex)
            {
                throw new Exception("Error metodo Prog calc - Metodo Restar" + ex);
            }
        }
        public static double Residuo(double a, double b)
        {
            try
            {
                Resultado = a % b;
                Memoria.Add(Resultado);
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error metodo Prog calc - Metodo Restar" + ex);
            }
        }
        public static double Porcentaje(double a, double b)
        {
            try
            {
                Resultado = (a * b) / 100;
                Memoria.Add(Resultado);
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error metodo Prog calc - Metodo Restar" + ex);
            }
        }
    }
}
