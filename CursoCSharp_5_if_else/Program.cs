using System;

namespace CursoCSharp_5_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            var numero = 5;
            switch (numero)
            {
                case 1: Console.Write("Es un uno");
                    break;
                case 5:
                    Console.Write("Es un cinco");
                    break;
                case 9:
                    Console.Write("Es un nueve");
                    break;
                case 15:
                    Console.Write("Es un quince");
                    break;
                default: Console.Write("No coincide con nada");
                    break;
            }
        }
    }
}
