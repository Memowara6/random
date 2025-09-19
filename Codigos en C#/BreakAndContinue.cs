using System;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int contador = 0; contador < 12; contador++)
            {
                if (contador %2 == 1)
                {
                    Console.WriteLine(contador);
                    continue;
                }
               
            }
            Console.Read();
        }

    }
}
