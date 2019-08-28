using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Constructores
{
    class Persona
    {
        #region Propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Codigo { get; set; }
        public string Guiaaprendizaje { get; set; }
        public string Duracion { get; set; }
        public string Ficha { get; set; }


        #endregion
        #region Constructores
        public Persona(string nombre, string apellido, int codigo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Codigo = codigo;
        }

        public Persona(string guiaaprendizaje, string duracion, string ficha)
        {
            Guiaaprendizaje = guiaaprendizaje;
            Duracion = duracion;
            Ficha = ficha;

        }

        public Persona(string nombre, string apellido, int codigo, string guiaaprendizaje, string duracion, string ficha)
        {
            Nombre = nombre;
            Apellido = apellido;
            Codigo = codigo;
            Guiaaprendizaje = guiaaprendizaje;
            Duracion = duracion;
            Ficha = ficha;
        }

        public Persona()
        {

        }

        #endregion

        #region Métodos

        public void IngresarPersona()
        {
            
            Console.WriteLine("Ingrese el Nombre del Aprendiz");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el Apellido del Aprendiz");
            Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el Codigo del aprendiz");
            Codigo = int.Parse(Console.ReadLine());
        }


        public void IngresarGuia()
        {
            
            Console.WriteLine("Ingrese el Nombre de la guia");
            Guiaaprendizaje = Console.ReadLine();
            Console.WriteLine("Ingrese la duracion de la guia");
            Duracion = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de ficha ");
            Ficha = Console.ReadLine();

        }



        public void Imprimir()
        {
            
                Console.WriteLine($"El Nombre del Aprendiz:{Nombre}");
                Console.WriteLine($"El Apellido del Aprendiz:{Apellido}");
                Console.WriteLine($"El Codigo del Aprendiz:{Codigo}");
            
        }


        public void Modificar(string N, string A)
        {

            Nombre = N;
            Apellido = A;

        }



        #endregion
    }
}
