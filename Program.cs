using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //0 1 1 2 3 5 8 13 ...
            
            int a = 0,  b = 1, c = 0;

            Console.Write("Quantos valores: ");
            int valores = int.Parse(Console.ReadLine());

            Console.WriteLine("Sequência de Fibonacci com  {0} valores!", valores);

            for(int i = 0; i <valores; i++)
            {
                if(i < valores - 1)
                {
                    Console.Write(a + ", ");
                }
                else
                {
                     Console.WriteLine(a);
                }
                
                c = a + b;
                a = b;
                b = c;

            }
            Console.ReadKey();//para ter um pause no final
        }
    }
}
