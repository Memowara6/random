using System;

namespace Ingreso_del_usuario
{
    class Program
    {
        static void Main(string[] args)
        {

            //Mostrara el resultado
            Console.WriteLine(Calcular());
            Console.Read();

        }

        public static string Calcular()
        {
            //Le pedira al usuario un numero
            Console.WriteLine("Por favor, ingrese un numero");
            string Numero1input = Console.ReadLine();
            int num1 = Int32.Parse(Numero1input);

            //Le pedira al usuario otro numero
            Console.WriteLine("Por favor, ingrese un numero");
            string Numero2input = Console.ReadLine();
            int num2 = Int32.Parse(Numero2input);

            //Suma entre los dos numeros
            int resultado = num1 + num2;

            //Esto es lo que va a devolver el metodo
            return $"Su resultado fue: {num1} + {num2} = {resultado}";
        }
    }
}


        
         
    

