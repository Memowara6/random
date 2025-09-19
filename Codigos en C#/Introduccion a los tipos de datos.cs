using System;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------------Ejemplos de variables integer-------------
             int num1 = 13;
             int num2 = 5;
             int sum = num1 + num2;
             Console.WriteLine(" La suma de " + num1 + " mas " + num2 + " da como resultado " + sum);
             Console.Read();

            // ----------------Ejemplos de variables double----------------
             double d1 = 1.5;
             double d2 = 1.546;
             double sumd = d1 + d2;
             Console.WriteLine(" La suma de " + d1 + " mas " + d2 + " da como resultado " + sumd);
             Console.Read();

            // -------Ejemplos de combinación entre doubles e integer--------
             double sumdi = d1 + num2;
            // IMPORTANTE (Para realizar una operación que involucre decimales y enteros,
            // es importante usar un dato primitivo de decimales
             Console.WriteLine(" La suma de " + d1 + " mas " + num2 + " da como resultado " + sumdi);
             Console.Read();

            //------------------Ejemplos con datos de texto----------
            string MiNombre = "Carlos";
            string mensaje = "Mi nombre es " + MiNombre;
            string MensMin = mensaje.ToLower();
            Console.WriteLine(MensMin);
            Console.Read();
            




        }
    }
}
