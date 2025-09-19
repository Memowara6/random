using System;

namespace DeclaracionIfMejorada
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperatura = 1000;
            string estadoDelAgua;

            //If con algunos cambios
            if (temperatura < 1)
                estadoDelAgua = "sólido";
            else if (temperatura > 0 && temperatura < 101)
                estadoDelAgua = "Liquido";
            else
                estadoDelAgua = "Gaseoso";

            Console.WriteLine("El estado del agua es " + estadoDelAgua);
            Console.Read();

            //La Sintaxis es: Condición ? (respuesta si la condicion se cumple) : (respuesta si la condicion no se cumple);
            //Para hacer una especie de 'else if', en vez de colocar la segunda respuesta, se hace otra pregunta. Como se muestra abajo
            estadoDelAgua = temperatura < 1 ? "Sólido" : temperatura > 0 && temperatura < 101 ? "Liquido" : "Gaseoso";

            Console.WriteLine("El estado del agua es " + estadoDelAgua);
            Console.Read();
        }
    }
}
