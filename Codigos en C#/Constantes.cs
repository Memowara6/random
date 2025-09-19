using System;

namespace Constantes
{
    class Program
    {
        const double PI = 3.1415;
        const string fechaNacimiento = "06.07.2005";
        static void Main(string[] args)
        {
            Console.WriteLine("Mi fecha de nacimiento es {0}", fechaNacimiento);
            Console.Read();
        }
    }
}
