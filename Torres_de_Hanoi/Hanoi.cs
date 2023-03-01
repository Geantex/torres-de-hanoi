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
            bool moverDisco = false; // Se ha movido el disco??
            // Pila a es la pila donde cogemos el disco, Pila b es donde lo dejamos
            // Podria ser util que push() devuelva verdadero o falso dependiendo de si ha podido mover el disco
            if(a.Size != 0){
             moverDisco = b.push(a.Elementos.Last());
            }
             if(moverDisco){
                a.pop();  
                Console.WriteLine("Probando!");   
             }

             // Fin de la función
             return;
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int movimientos = 0;
            if(n == 1) {
                mover_disco(ini,fin);
            }
            else{
                // Hay que mover todos menos un disco a AUX,
                // después movemos el único disco que queda en INI a FIN,
                // y movemos de la misma manera todos los discos a FIN
                // Estos 3 movimientos son correctos
                mover_disco(ini,fin);
                movimientos++;
                mover_disco(ini,aux);
                movimientos++;
                mover_disco(fin,aux);
                movimientos++;
                /*while(ini.Size > 1){
                    
                }*/
                // CAMBIAMOS A MOVER EL DISCO INICIAL A FIN
                mover_disco(ini,fin);
                movimientos++;
                /*while(fin.Size != n){
                    
                }*/
                Console.WriteLine("Ejercicio resuelto");

            }
            return movimientos;
        }

    }
}
