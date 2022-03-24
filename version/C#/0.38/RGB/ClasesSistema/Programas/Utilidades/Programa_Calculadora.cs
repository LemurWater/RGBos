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
    public  class Programa_Calculadora: Sistema
    {
        //Atributos
        private  string version = "0.1";

        private  double valor_a;
        private  double valor_b;
        private  string valor_c;
        private  double resultado;

        private  List<List<string>> memoria = new List<List<string>>();  //Operacion-Resultado


       private  Enum_Operacion operacion;

        //Accesores
        public  double Valor_a { get => valor_a; set => valor_a = value; }
        public  double Valor_b { get => valor_b; set => valor_b = value; }
        public  double Resultado { get => resultado; set => resultado = value; }
        public  List<List<string>> Memoria { get => memoria; }
        public  Enum_Operacion Operacion { get => operacion; set => operacion = value; }

        //Metodos
        public  string Version()
        {
            return version;
        }
        //
        public  bool Cambiar_Operacion(Enum_Operacion nueva_operacion)
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
        public  bool Cambiar_Valor_A(char valor)
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
        public  bool Cambiar_Valor_B(char valor)
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
        public  bool Cambiar_Valor_A(double valor)
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
        public  bool Cambiar_Valor_B(double valor)
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
        public  Enum_Operacion Obtener_Operacion()
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
        public  double Obtener_Valor_A()
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
        public  double Obtener_Valor_B()
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
        public  List<List<string>> Obtener_Memoria()
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
        public  List<string> Obtener_Ultima_Memoria()
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
        public  double Sumar(double a, double b)
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

        public  double Restar(double a, double b)
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
        public  double Multiplicar(double a, double b)
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
        public  double Dividir(double a, double b)
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
        public  double Residuar(double a, double b)
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
        public  double Porcentuar(double a, double b)
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
        public  double Potenciar(double a, double b)
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
        public  double Radicar(double a, double b)
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
        public  string Derivar(string c)
        {
            try
            {
                string tmp_string = "";
                double fx = 0.0000000000000001;
                // Resultado = [f(valor_c + fx) - f(valor_c)] / dx
                List<string> tmp_valor = new List<string>() { "DERIV", Resultado.ToString() };

                Memoria.Add(tmp_valor);
                return tmp_string;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Clase: Programa_Calculadora  - Metodo: Derivar" + ex);
            }
        }
        public  string Integrar(string c)
        {
            try
            {
                string tmp_string = "";
                double infinito = double.PositiveInfinity;
                //Resultado = c;
                List<string> tmp_valor = new List<string>() { "INTE", Resultado.ToString() };
                Memoria.Add(tmp_valor);
                return tmp_string;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Clase: Programa_Calculadora  - Metodo: Integrar" + ex);
            }
        }
    }
}
