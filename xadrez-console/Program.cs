using System;
using tabuleiro;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {
            Posicao p1 = new Posicao(5, 3);

            Tabuleiro tab = new Tabuleiro(9,9);

            Console.WriteLine("Posição: " + p1);

            Console.WriteLine("Tabuleiro : \n" + tab);
            
            Console.ReadLine();



        }
    }
}
