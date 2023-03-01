using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            bool moverDisco; // Se ha movido el disco??
            // Pila a es la pila donde cogemos el disco, Pila b es donde lo dejamos
            // Podria ser util que push() devuelva verdadero o falso dependiendo de si ha podido mover el disco
             moverDisco = b.push(a.Elementos.Last());
             if(moverDisco){
                a.pop();      
             }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            return 0;
        }

    }
}
