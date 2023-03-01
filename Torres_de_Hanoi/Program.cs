using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cambiar de 4 a número introducido por el usuario
            int n = 4;
            Pila ini = new Pila (n);
            Pila aux = new Pila ();
            Pila fin = new Pila ();
            int numeroDeMovimientos;
            Hanoi hanoi = new Hanoi();
            numeroDeMovimientos = hanoi.iterativo(n,ini,aux,fin);
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
