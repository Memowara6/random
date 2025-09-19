using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            EscribeAlgo();
            EscribeAlgoEspecífico("Soy un argumento y me llamaron desde un método");
            Console.Read();
        }

        // NivelDeAcceso - (static) - TipoDeRetorno - NombreDelMétodo (Parametro1, Parametro2)
        public static void EscribeAlgo()
        {
            Console.WriteLine("Yo nací en un método");
            
        }

        public static void EscribeAlgoEspecífico(string miTexto)
        {
            Console.WriteLine(miTexto);
            
        }
    }
}
