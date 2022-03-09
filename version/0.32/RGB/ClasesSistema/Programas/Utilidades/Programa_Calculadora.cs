using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB.ClasesSistema.Programas.Utilidades
{       
    //Enums
    public enum Enum_Operacion { Suma, Resta, Multiplicacion, Division, Residuo, Porcentaje, Elevar, Raiz, Derivacion, Integracion };

    //Clase
    public static class Programa_Calculadora
    {
        //Atributos
        private static string version = "0.1";

        private static double valor_a;
        private static double valor_b;
        private static string valor_c;
        private static double resultado;

        private static List<List<string>> memoria = new List<List<string>>();  //Operacion-Resultado


       private static Enum_Operacion operacion;

        //Accesores
        public static double Valor_a { get => valor_a; set => valor_a = value; }
        public static double Valor_b { get => valor_b; set => valor_b = value; }
        public static double Resultado { get => resultado; set => resultado = value; }
        public static List<List<string>> Memoria { get => memoria; }
        public static Enum_Operacion Operacion { get => operacion; set => operacion = value; }

        //Metodos
        public static string Version()
        {
            return version;
        }
        //
        public static bool Cambiar_Valor_A(char valor)
        {
            try
            {
                if((1 + Valor_a.ToString().Length) >= double.MaxValue)
                {
                    throw new Exception("El numero es mayor al permitido");
                }
                else
                {
                    Valor_a = double.Parse(valor_a.ToString() + valor);
                    return true;
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Error en Clase: Programa_Calculadora  - Metodo: Cambiar_Valor_A(string)" + ex);
            }
        }
        public static bool Cambiar_Valor_B(char valor)
        {
            try
            {
                if ((1 + Valor_b.ToString().Length) >= double.MaxValue)
                {
                    throw new Exception("El segundo numero es mayor al permitido");
                }
                else
                {
                    Valor_b = double.Parse(valor_b.ToString() + valor);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Clase: Programa_Calculadora  - Metodo: Cambiar_Valor_A(string)" + ex);
            }
        }
        public static bool Cambiar_Operacion(Enum_Operacion nueva_operacion)
        {
            try
            {
                Operacion = nueva_operacion;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Clase: Programa_Calculadora  - Metodo: Cambiar_Operacion" + ex);
            }
        }
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
                throw new Exception("Error en Clase: Programa_Calculadora - Metodo: Cambiar_Valor_A" + ex);
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
                throw new Exception("Error en Clase: Programa_Calculadora  - Metodo: Cambiar_Valor_B" + ex);
            }
        }
        //
        public static Enum_Operacion Obtener_Operacion()
        {
            try
            {
                return Operacion;
            }
            catch(Exception ex)
            {
                throw new Exception("Error en Clase: Programa_Calculadora - Metodo: Obtener_Operacion" + ex);
            }
        }
        public static double Obtener_Valor_A()
        {
            try
            {
                return Valor_a;
            }
            catch(Exception ex)
            {
                throw new Exception("Error en Clase: Programa_Calculadora - Metodo: Obtener_Valor_A" + ex);
            }
        }
        public static double Obtener_Valor_B()
        {
            try
            {
                return Valor_b;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Clase: Programa_Calculadora - Metodo: Obtener_Valor_B" + ex);
            }
        }
        public static List<List<string>> Obtener_Memoria()
        {
            try
            {
                return Memoria;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Clase: Programa_Calculadora - Metodo: Obtener_Memoria" + ex);
            }
        }
        public static List<string> Obtener_Ultima_Memoria()
        {

            try
            {
                return Memoria.Last();
            }
            catch(Exception ex)
            {
                throw new Exception("Error en Clase: Programa_Calculadora - Metodo: Obtener_Ultima_Memoria" + ex);
            }
        }
        //
        public static double Sumar(double a, double b)
        {
            try
            {          
                Resultado = a + b + 0;

                List<string> tmp_valor = new List<string>() { "SUMA", Resultado.ToString() };

                Memoria.Add(tmp_valor);
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Clase: Programa_Calculadora  - Metodo: Sumar" + ex);
            }           
        }

        public static double Restar(double a, double b)
        {
            try
            {
                Resultado = a - b;
                List<string> tmp_valor = new List<string>() { "RESTA", Resultado.ToString() };

                Memoria.Add(tmp_valor);
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Clase: Programa_Calculadora  - Metodo: Restar" + ex);
            }
        }
        public static double Multiplicar(double a, double b)
        {
            try
            {
                Resultado = a * b;
                List<string> tmp_valor = new List<string>() { "MULT", Resultado.ToString() };

                Memoria.Add(tmp_valor);
                return Resultado;
            }
            catch(Exception ex)
            {
                throw new Exception("Error en Clase: Programa_Calculadora  - Metodo: Multiplicar" + ex);
            }
        }
        public static double Dividir(double a, double b)
        {
            try
            {

                Resultado = a / b;
                List<string> tmp_valor = new List<string>() { "DIVI", Resultado.ToString() };

                Memoria.Add(tmp_valor);
                return Resultado;
            }
            catch(Exception ex)
            {
                throw new Exception("Error en Clase: Programa_Calculadora  - Metodo: Dividir" + ex);
            }
        }
        public static double Residuar(double a, double b)
        {
            try
            {
                Resultado = a % b;
                List<string> tmp_valor = new List<string>() { "RESID", Resultado.ToString() };

                Memoria.Add(tmp_valor);
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Clase: Programa_Calculadora  - Metodo: Residuar" + ex);
            }
        }
        public static double Porcentuar(double a, double b)
        {
            try
            {
                Resultado = (a * b) / 100;
                List<string> tmp_valor = new List<string>() { "PORCE", Resultado.ToString() };

                Memoria.Add(tmp_valor);
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Clase: Programa_Calculadora  - Metodo: Porcentuar" + ex);
            }
        }
        public static double Potenciar(double a, double b)
        {
            try
            {
                Resultado = Math.Pow(a, b);
                List<string> tmp_valor = new List<string>() { "POTEN", Resultado.ToString() };

                Memoria.Add(tmp_valor);
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Clase: Programa_Calculadora  - Metodo: Potenciar" + ex);
            }
        }
        public static double Radicar(double a, double b)
        {
            try
            {
                Resultado = Math.Pow(a,  1 / b);
                List<string> tmp_valor = new List<string>() { "RADIC", Resultado.ToString() };

                Memoria.Add(tmp_valor);
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Clase: Programa_Calculadora  - Metodo: Radicar" + ex);
            }
        }
        public static double Derivar(string c)
        {
            try
            {
                double fx = 0.0000000000000001;
                // Resultado = [f(valor_c + fx) - f(valor_c)] / dx
                List<string> tmp_valor = new List<string>() { "DERIV", Resultado.ToString() };

                Memoria.Add(tmp_valor);
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Clase: Programa_Calculadora  - Metodo: Derivar" + ex);
            }
        }
        public static double Integrar(string c)
        {
            try
            {
                double infinito = double.PositiveInfinity;
                //Resultado = c;
                List<string> tmp_valor = new List<string>() { "INTE", Resultado.ToString() };
                Memoria.Add(tmp_valor);
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Clase: Programa_Calculadora  - Metodo: Integrar" + ex);
            }
        }
    }
}
