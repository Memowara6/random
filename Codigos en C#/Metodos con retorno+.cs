using System;

namespace MetodosConRetorno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiplica(3, 4));
            Console.Read();
        }

        public static int Multiplica(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2
        }

        public static int Suma(int num1, int num2)
        {
            return num1 + num2
        }
    }
}
