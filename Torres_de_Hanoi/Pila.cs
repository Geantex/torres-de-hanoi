using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    // HE SUSTITUIDO LAS LISTS POR STACKS IMPORTANTE!!!
    class Pila
    {
        public int Size { get; set; }
        public int Top { get; set; }
        public Stack<Disco> Elementos { get; set; }


        /* TODO: Implementar métodos */
        public Pila()  // pila vacía
        {
            Size = 0;
            Top = 0;
            Elementos = new Stack<Disco>();
        }

        public Pila(int n){  //pila que dependiendo de del numero q pongas va a crear pilas de discos hasta n
            
            Size = n;
            Elementos = new Stack<Disco>(); 

            for(int i=n; i > 0; i--){

                Disco disco = new Disco(); //crear disco vacío
                disco.Valor = n-i;       // Dar valor al disco
                Elementos.Push(disco);   //Anyadir disco a la pila
            }
            Top = Elementos.Last().Valor;
        }

        public bool push(Disco d){
            if(d.Valor > Elementos.Last().Valor){
                Console.Write("No se puede hacer el push ");
                return false;
            }
            else{
                Elementos.Push(d);  //anyade el disco 
                Size = Elementos.Count(); // Cuenta todos los eleementos 
                Top = Elementos.Last().Valor; //selecciona el último elemento de la lista
                return true;
            }
        }

        public void pop(){
            if(Elementos.Count() == 0){
                Console.Write("No se puede hacer el pop ");
            }

            else{
                Elementos.Pop();  // Quita el último elemento de la lista
                Size = Elementos.Count();   
                Top = Elementos.Last().Valor;
            }
            return;
        }                

        public bool isEmpty(){
            if(Elementos.Count() == 0){
                return true;
            }
            else{
                return false;
            }
        }
    }
}