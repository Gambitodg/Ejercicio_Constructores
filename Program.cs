using System;

namespace Ejercicio_Constructores
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona ejercicio1 = new Persona();
            ejercicio1.IngresarPersona();
            ejercicio1.Imprimir();
            ejercicio1.Modificar("Jonnatan","Beltran");
            ejercicio1.Imprimir();









            Console.ReadLine();
        }
    }
}
