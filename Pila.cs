using System;

namespace Estructuras_Datos_TPE
{
    public class Pila
    {
        private Nodo Primero = new Nodo();

        public Pila()
        {
            Primero = null;
        }

        public void insertarNodo()
        {
            Nodo nuevo = new Nodo();
            System.Console.WriteLine("Ingrese el dato de la pila");
            nuevo.Dato = int.Parse(Console.ReadLine());
            
            nuevo.Siguiente = Primero;
            Primero = nuevo;
            
            System.Console.WriteLine("\n Nodo Ingresado\n\n");

        }

        public void buscarNodo()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            bool Encontrado = false;
            System.Console.WriteLine(" Ingrese el dato del nodo buscado");
            int nodoBuscado = int.Parse(Console.ReadLine());

            if (Primero != null)
            {
                while (Actual != null && Encontrado != true)
                {
                    if(Actual.Dato == nodoBuscado)
                    {
                        System.Console.WriteLine("\n El nodo con el dato ( {0} ) Encontrado\n", nodoBuscado);
                        Encontrado = true;
                    }
                    Actual = Actual.Siguiente;
                }

                if (!Encontrado)
                {
                    System.Console.WriteLine("\n Nodo no encontrado\n");
                }

            }
            else
            {
                System.Console.WriteLine("\n La pila se encuentra vacia\n\n");
            }
        }

        public void modificarNodo()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            bool Encontrado = false;
            System.Console.WriteLine(" Ingrese el dato del nodo buscado para modificar");
            int nodoBuscado = int.Parse(Console.ReadLine());

            if (Primero != null)
            {
                while (Actual != null && Encontrado != true)
                {
                    if(Actual.Dato == nodoBuscado)
                    {
                        System.Console.WriteLine("\n El nodo con el dato ( {0} ) Encontrado\n", nodoBuscado);
                        System.Console.WriteLine("\n Ingrese el nuevo dato para este nodo: ");
                        Actual.Dato = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("\n Nodo Modificado: \n");
                        
                        Encontrado = true;
                    }
                    Actual = Actual.Siguiente;
                }

                if (!Encontrado)
                {
                    System.Console.WriteLine("\n Nodo no encontrado\n");
                }

            }
            else
            {
                System.Console.WriteLine("\n La pila se encuentra vacia\n\n");
            }
        }

        public void desplegarPila()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;

            if (Primero != null)
            {
                while (Actual != null)
                {
                    System.Console.WriteLine(" "+Actual.Dato);
                    Actual = Actual.Siguiente;
                }
            }
            else
            {
                System.Console.WriteLine("\n La pila se encuentra vacia\n\n");
            }
        }

    }
}