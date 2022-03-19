using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RGB.Interfaces;

using RGB.ClasesSistema.Programas;

namespace RGB.ClasesSistema
{
    public class Escritorio : Sistema
    {
        private Interface_Escritorio form_escritorio = new Interface_Escritorio();
        private bool crear_escritorio = true;

        private List<Archivo> l_archivos = new List<Archivo>();


        private byte tamano_variable_x, tamano_variable_y;
        private byte tamano_fijo_x, tamano_fijo_y;
        private bool tamano_fijo;

        private byte tamano_icono_x = 1, tamano_icono_y = 1;

        public Escritorio()
        {
            
        }

        public Escritorio(List<Archivo> l_archivos, byte tamano_variable_x, byte tamano_variable_y, byte tamano_fijo_x, byte tamano_fijo_y, bool tamano_fijo, byte tamano_icono_x, byte tamano_icono_y)
        {
            L_archivos = l_archivos;
            Tamano_variable_x = tamano_variable_x;
            Tamano_variable_y = tamano_variable_y;
            Tamano_fijo_x = tamano_fijo_x;
            Tamano_fijo_y = tamano_fijo_y;
            Tamano_fijo = tamano_fijo;

            Tamano_icono_x = tamano_icono_x;
            Tamano_icono_y = tamano_icono_y;
        }

        public bool Tamano_fijo { get => tamano_fijo; set => tamano_fijo = value; }
        public byte Tamano_variable_x { get => tamano_variable_x; set => tamano_variable_x = value; }
        public byte Tamano_variable_y { get => tamano_variable_y; set => tamano_variable_y = value; }
        public byte Tamano_fijo_x { get => tamano_fijo_x; set => tamano_fijo_x = value; }
        public byte Tamano_fijo_y { get => tamano_fijo_y; set => tamano_fijo_y = value; }
        public  List<Archivo> L_archivos { get => l_archivos; set => l_archivos = value; }
        public byte Tamano_icono_x { get => tamano_icono_x; set => tamano_icono_x = value; }
        public byte Tamano_icono_y { get => tamano_icono_y; set => tamano_icono_y = value; }


        //Metodos

        //
        public void Usar_Escritorio()
        {
            try
            {
                Program.Mensaje_Del_Sistema("Escritorio");
                Mostrar_Iconos();
                //Forms
                if (crear_escritorio)
                {
                    form_escritorio.ShowDialog();
                    crear_escritorio = false;
                }             
            }
            catch (Exception ex)
            {
                throw new Exception("Error metodo usar_escritorio " + ex);
            }
        }

        public bool Mostrar_Iconos()
        {   
            try
            {
                Console.WriteLine(" 1 2 3 4 5 6");
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error Clase: Escritorio - Metodo: Mostrar_Iconos() " + ex);
            }
        }
        //
        public List<Archivo> Obtener_Archivos()
        {
            try
            {
                return L_archivos;
            }
            catch(Exception ex)
            {
                throw new Exception("Error Clase: Escritorio - Metodo: Obtener_Iconos()" + ex);
            }
        }
        public bool Agregar_Archivo(Archivo archivo)
        {
            try
            {/*
                List<Archivo> _list = L_archivos.Last();
                _list.Add(archivo);
                L_archivos.RemoveAt(L_archivos.Count);
                L_archivos.Add(_list);*/
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error Clase: Escritorio - Metodo: Agregar_Archivo(Archivo archivo)" + ex);
            }
        }
        //
        public bool Calcular_Distribucion()
        {
            try
            {
                List<Archivo> _l_archivos = new List<Archivo>();
                bool _devolver = true ;
                double _matriz_cuadrada = new double();

               /* foreach (List<Archivo> l_ar in L_archivos)
                {
                    foreach (Archivo ar in l_ar)
                    {
                        _l_archivos.Add(ar);
                    }
                }*/
                //
                switch (Tamano_fijo)
                {
                    case true:
                        {
                           /* byte index = 0;
                            List<Archivo> _archivo_x = new List<Archivo>();
                            List<List<Archivo>> _archivo_y = new List<List<Archivo>>();

                            for (int i = 1; i < Tamano_fijo_x; i++)
                            {
                                

                                for (int j = 0; j < Tamano_fijo_y; j++)
                                {
                                    _archivo_x.Add(_l_archivos.First());
                                    _l_archivos.RemoveAt(0);
                                }
                                _archivo_y.Add(_archivo_x);
                            }
                            L_archivos = _archivo_y;*/
                            break;
                        }

                    case false:
                        {


                            _matriz_cuadrada = Math.Sqrt(_l_archivos.Count);

                            if (_l_archivos.Count % Math.Sqrt(_l_archivos.Count) == 0)
                            {
                                _devolver = true;
                            }
                            else
                            {
                                _devolver = false;
                            }
                            break;
                        }
                }

                for (int i = 0; i < _matriz_cuadrada; i++)
                {

                }

                return _devolver;
            }
            catch (Exception ex)
            {
                throw new Exception("Error Clase: Escritorio - Metodo: Calcular_Distribucion()" + ex);
            }
        }
      

    }
}
