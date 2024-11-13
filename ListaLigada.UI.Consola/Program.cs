using ListaLigada.Logica;
using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lista ligada simple \n");


        var singleList = new SingleList<string>();
        int opcion = 0;
        do
        {
            switch (opcion)
            {

                case 1: AgregarElemento(); break;
                case 2: MostrarLista(); break;
                case 3: EliminarElemento(); break;
                //default: Console.WriteLine("La opcion no existe"); break;



            }

            opcion = Menu();

        } while (opcion != 0);
        void AgregarElemento()
        {
            Console.Write("** Agregar elementos a la lista ** \n");
            Console.Write("Escriba el nombre del nodo: ");
            var nombre = Console.ReadLine();
            singleList.Add(nombre);

        }
       void MostrarLista()
        {
            if (singleList.isEmpty)
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                Console.WriteLine(singleList);
            }

        }

      void EliminarElemento()
        {
            throw new NotImplementedException();
        }

        Console.ReadKey();


    }//fin de main

  

    private static int Menu()
    {
        Console.WriteLine("Menu \n");
        Console.WriteLine("1. Agregar elemento");
        Console.WriteLine("2. Mostrar Lista");
        Console.WriteLine("3. Eliminar elemento");
        Console.WriteLine("0. Salir");

        bool valido = false;
        int opcion = 0;

        do
        {
            Console.WriteLine(" \n Seleccione una opcion del menu : ");
            var opcionCapturada = Console.ReadLine();
            Console.WriteLine("");
            if (!int.TryParse(opcionCapturada, out opcion) || opcion < 0 || opcion > 2)
            {

                Console.WriteLine(" Elige una opcion valida \n");
                valido = false;
            }
            else
            {
                valido = true;
            }
;

        } while (valido == false);

        return opcion;


    }
}
