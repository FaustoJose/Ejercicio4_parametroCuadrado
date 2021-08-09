using System;

namespace Ejercicio5_parametroCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuadrado(10,10);
        }
        public static void Cuadrado(int altura, int anchura)
        {
            for (int i=0;i<=(altura-1);i++) {
                for (int f = 0; f <= (anchura - 1); f++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }

                Console.WriteLine("");
            }
        }
    }
}
