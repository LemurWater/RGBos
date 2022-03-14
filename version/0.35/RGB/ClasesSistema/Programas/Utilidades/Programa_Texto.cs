using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB.ClasesSistema.Programas.Utilidades
{
    public class Programa_Texto
    {
        //Atributos
        private string titulo;
        private string texto;
        private string resaltado;

        //Constructores
        public Programa_Texto(string titulo, string texto, string resaltado)
        {
            Titulo = titulo;
            Texto = texto;
            Resaltado = resaltado;
        }

        //Metodos
        public string Devolver_Titulo()
        {
            return Titulo;
        }
        public string Devolver_Texto()
        {
            return Texto;
        }
        public string Devolver_Resaltado()
        {
            return Resaltado;
        }
        public void Cambiar_Titulo(string nuevo_titulo)
        {
            Titulo = nuevo_titulo;
        }
        public void Cambiar_Texto(string nuevo_texto)
        {
            Texto = nuevo_texto;
        }
        public void Cambiar_Resaltado(string nuevo_resaltado)
        {
            Resaltado = nuevo_resaltado;
        }


        //Accesores
        public string Titulo { get => titulo; set => titulo = value; }
        public string Texto { get => texto; set => texto = value; }
        public string Resaltado { get => resaltado; set => resaltado = value; }
    }
}
