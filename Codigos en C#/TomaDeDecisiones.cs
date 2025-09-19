using System;

namespace TomaDeDeciciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿A qué temperatura se encuentra? (En Celsius)");
            string userTemp = Console.ReadLine();


            //Se intentara ejecutar si el valor ingresado por el usuario se puede transformar a integer
            try
            {
                //Se convierte el valor sel usuario a integer
                int userTemperture = int.Parse(userTemp);
                //Valor de la temperatura que soporta el ser humano
                int temperatura = 35;
                //Si la temperatura del usuario es igual o menor a 35 y que sea mayor que 0, se hara eso
                if (userTemperture == temperatura || userTemperture < temperatura && userTemperture > 0)
                {
                    Console.WriteLine("Te recomendamos llevar una ropa comoda que el clima esta fresco");
                }
                //Si la temperatura del usuario es mayor que 35, entonces se hara eso
                else if (userTemperture > temperatura)
                {
                    Console.WriteLine("Te recomendamos no salir de la casa porque hace mucha calor");
                }
                //Si la temperatura del usuario es menor que 0 o es igual a 0, entonces se hara eso
                else if (userTemperture < 0 || userTemperture == 0)
                {
                    Console.WriteLine("Te recomendamos ir bien abrigado porque hace mucho frio");
                }
                else
                {
                    Console.WriteLine("Prueba realizada con exito");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("No has introducido ningun valor");
            }



        }
    }
}
