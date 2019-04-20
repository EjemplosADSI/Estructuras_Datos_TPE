using System;

namespace Estructuras_Datos_TPE
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila P = new Pila();

            int opcionMenu = 0;

            do
            {
             System.Console.WriteLine("\n|-------------------------------|");
                System.Console.WriteLine("|     * Concepto de Pila *      |");
                System.Console.WriteLine("|---------------|---------------|");
                System.Console.WriteLine("| 1. Insertar   | 4. Eliminar   |");
                System.Console.WriteLine("| 2. Buscar     | 5. Desplegar  |");
                System.Console.WriteLine("| 3. Modificar  | 6. Salir      |");
                System.Console.WriteLine("|---------------|---------------|");
                System.Console.WriteLine("|     Selecciona una Opcion     |");
                opcionMenu = int.Parse(Console.ReadLine());
                switch (opcionMenu)
                {
                    case 1:
                        System.Console.WriteLine("\n\n Insertar un nodo en la pila \n");
                        P.insertarNodo();
                        break;
                    case 2:
                        System.Console.WriteLine("\n\n Buscar un nodo en la pila \n");
                        P.buscarNodo();
                        break;
                    case 3:
                        System.Console.WriteLine("\n\n Modificar un nodo en la pila \n");
                        P.modificarNodo();
                        break;
                    case 4:
                        System.Console.WriteLine("\n\n Eliminar un nodo en la pila \n");
                        break;
                    case 5:
                        System.Console.WriteLine("\n\n Desplegar pila de nodos \n");
                        P.desplegarPila();
                        break;
                    case 6:
                        System.Console.WriteLine("\n\n Programa Finalizado.... \n");
                        break;
                    default:
                        System.Console.WriteLine("\n\n Opcion No Valida.... \n");
                        break;
                }
            } while (opcionMenu != 6);

        }
    }
}
