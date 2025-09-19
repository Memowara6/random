using System;

namespace CreandoClases
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crea un nuevo objeto desde mi clase

            // Una nueva instancia de Humano
            Humano juan = new Humano();

            //Accediendo a una variable publica
            juan.primerNombre = "Juan";
            juan.apellido = "Riquelme";

            //Llamando a un metodo de la clase
            juan.presentarme();
            Console.Read();

            Humano guille = new Humano();
            guille.primerNombre = "Guillermo";
            guille.apellido = "Ramos";
            guille.presentarme();





        }
    }
}
