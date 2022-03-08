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
        private long valor_a;
        private long valor_b;
        private long resultado;

        //Constructores
        public Programa_Calculadora(long valor_a, long valor_b, long resultado)
        {
            Valor_a = valor_a;
            Valor_b = valor_b;
            Resultado = resultado;
        }
        //Accesores
        public long Valor_a { get => valor_a; set => valor_a = value; }
        public long Valor_b { get => valor_b; set => valor_b = value; }
        public long Resultado { get => resultado; set => resultado = value; }

        //Metodos
        public long Sumar(long a, long b)
        {
            Resultado = a + b;
            return Resultado;
        }
        public long Restar(long a, long b)
        {
            return Resultado;
        }
    }
}
