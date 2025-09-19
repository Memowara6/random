using System;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 9;
            int num3;

            //Operadores unarios
            num3 = -num1;
            Console.WriteLine("El valor negativo de num1 es {0}", num3);

            bool haySol = true;
            Console.WriteLine("¿Hay sol? {0}", !haySol);

            //Operadores de adición
            int num = 0;
            num++;
            Console.WriteLine("num es {0}", num);
            Console.WriteLine("num es {0}", num++);
            Console.WriteLine("num es {0}", num);

            //Operadores de sustracción
            num--;
            Console.WriteLine("num es {0}", num);
            Console.WriteLine("num es {0}", --num);
            Console.WriteLine("num es {0}", num);


            //Operadores matematicos
            int resultado = num1 + num2;
            Console.WriteLine("El resultado de " + num1 + " + " + num2 + " es igual a " + resultado);
            resultado = num1 - num2;
            Console.WriteLine("El resultado de " + num1 + " - " + num2 + " es igual a " + resultado);
            resultado = num1 * num2;
            Console.WriteLine("El resultado de " + num1 + " * " + num2 + " es igual a " + resultado);
            resultado = num1 / num2;
            Console.WriteLine("El resultado de " + num1 + " / " + num2 + " es igual a " + resultado);

            //Operador modular
            resultado = num1 % num2;
            Console.WriteLine("El resultado de " + num1 + " % " + num2 + " es igual a " + resultado);

            //Operadores relacionales
            bool esMenor;
            esMenor = num1 < num2;
            Console.WriteLine("El resultado de " + num1 + " < " + num2 + " es igual a " + esMenor);

            //Operadores de igualdad
            bool esIgual;
            esIgual = num1 == num2;
            Console.WriteLine("El resultado de " + num1 + " == " + num2 + " es igual a " + esMenor);

            esIgual = num1 != num2;
            Console.WriteLine("El resultado de " + num1 + " != " + num2 + " es igual a " + esMenor);

            //Operadores condicionales
            //Y
            bool esMenorYSoleado;
            esMenorYSoleado = esMenor && haySol;
            Console.WriteLine("El resultado de " + esMenor + " && " + haySol + " es igual a " + esMenor);

            //O
            esMenorYSoleado = esMenor || haySol;
            Console.WriteLine("El resultado de " + esMenor + " || " + haySol + " es igual a " + esMenor);

            Console.Read();


        }
    }
}
