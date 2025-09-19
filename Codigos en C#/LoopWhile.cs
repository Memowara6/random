using System;

namespace LoopWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int estudiantes = 1;
            string textoIngresado = "";

            Console.WriteLine("Pulse la tecla enter cada vez que se suba un estudiante al autobus");
            
            while (textoIngresado.Equals(""))
            {
                string pulso = Console.ReadLine();
                if (pulso == "")
                {
                    Console.WriteLine("Se subio estudiante");
                    estudiantes++;
                }
                else if (pulso != "")
                {
                    break;
                }  

            }
            Console.WriteLine("Se han montando " + estudiantes + " estudiantes al autobús");
            Console.Read();


        }
    }
}
