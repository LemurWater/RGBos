using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB.ClasesSistema.Programas.Utilidades
{
    public class Programa_Calculadora
    {
        //Atributos
        private double valor_a;
        private double valor_b;
        private double resultado;

        private List<double> memoria = new List<double>();

        //Constructores
        public Programa_Calculadora(double valor_a, double valor_b, double resultado)
        {
            Valor_a = valor_a;
            Valor_b = valor_b;
            Resultado = resultado;
        }

        //Accesores
        public double Valor_a { get => valor_a; set => valor_a = value; }
        public double Valor_b { get => valor_b; set => valor_b = value; }
        public double Resultado { get => resultado; set => resultado = value; }
        public List<double> Memoria { get => memoria; }

        //Metodos
        public double Sumar(double a, double b)
        {
            Resultado = a + b;
            Memoria.Add(Resultado);
            return Resultado;
        }
        public double Restar(double a, double b)
        {
            Resultado = a - b;
            Memoria.Add(Resultado);
            return Resultado;
        }
        public double Multiplicar(double a, double b)
        {
            Resultado = a * b;
            Memoria.Add(Resultado);
            return Resultado;
        }
        public double Dividir(double a, double b)
        {
            Resultado = a / b;
            Memoria.Add(Resultado);
            return Resultado;
        }
        public double Residuo(double a, double b)
        {
            Resultado = a % b;
            Memoria.Add(Resultado);
            return Resultado;
        }
        public double Porcentaje(double a, double b)
        {
            Resultado = (a * b)/100;
            Memoria.Add(Resultado);
            return Resultado;
        }
    }
}
