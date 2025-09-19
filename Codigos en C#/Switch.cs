using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cantidad de autos
            int autos = 5;

            //Declaracion switch--(expresion a analizar)
            switch (autos)
            {
                //En caso que no tenga autos
                case 0:
                    Console.WriteLine("Usted no pagara impuestos");
                    break;

                //En caso que tenga un auto
                case 1:
                    Console.WriteLine("Usted debera de pagar $15 dolares");
                    break;
                //En caso que tenga dos autos
                case 2:
                    Console.WriteLine("Usted debera de pagar $30 dolares");
                    break;
                //En caso que no se cumpla con ninguna de estas condiciones
                default:
                    Console.WriteLine("Usted debera de pagar $15 dolares por auto");
                    break;

            }
            Console.Read();
        }
    }
}
