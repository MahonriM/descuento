using System;

namespace Descuento
{
    class Program
    {
        static void Main(string[] args)
        {/*Una tienda ofrece 15% de descuento sobre el total de la compra. Un
         cliente desea saber cuanto va a pagar al final de su compra.*/
         //Declaracion de variables
            double preciototal, total;
            //Entrada
            Console.WriteLine("Ingresa el total de tu compra");            preciototal =Convert.ToDouble( Console.ReadLine());            //Proceso
            total = preciototal * .15;
            //Salida
            Console.WriteLine("Lo que vas a pagar es :{0}",total);            Console.ReadLine();            //pausa
            Console.WriteLine("Presiona cualquier tecla para continuar");            Console.ReadKey();

        }
    }
}
