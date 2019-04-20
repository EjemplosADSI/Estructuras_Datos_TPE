using System;

namespace Estructuras_Datos_TPE
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila P = new Pila();

            P.insertarNodo();
            P.insertarNodo();
            P.insertarNodo();
            P.insertarNodo();
            P.insertarNodo();
            P.insertarNodo();

            System.Console.WriteLine("\nLa pila ingresada\n\n");
            P.desplegarPila();
        }
    }
}
