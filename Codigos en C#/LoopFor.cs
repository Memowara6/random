using System;

namespace LoopFor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Estructura del loop for
              for (valor inicial; condicion; incremento)
               {
                'Codigo a ejecutar'
               }
             */

            for (int contador = 0; contador < 10; contador++)
            {
                Console.WriteLine(contador);
            }
            Console.Read();

            //------------DESAFIO-------------
            for (int n = 1; n < 20; n += 2)
            {
                Console.WriteLine(n);
            }
          
            Console.WriteLine("Todos estos numeros son impares");
            Console.Read();


        }
    }
}
