using System;

namespace ManejoDeErrores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Explicacion del tema
            Console.WriteLine("Por favor ingrese un valor");
            string valorIngresado = Console.ReadLine();

            //Palabra clave try
            try
            {
                int valorComoInt = int.Parse(valorIngresado);
            }
            //En el parentesis se colocara el tipo de error que pensaremos que ocurrira
            catch (FormatException)
            {
                Console.WriteLine("El formato del valor ingresado es incorrecto");

            }
            catch (OverflowException)
            {
                Console.WriteLine("El numero ingresado es demaciado largo o demaciado corto");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No se ha ingresado ningún valor");
            }
            //Sin importar que suceda, el cuerpo de finally siempre aparecera
            finally
            {
                Console.WriteLine("Esta frase aparecerá pase lo qeu pase");
            }

            Console.Read();

            //-------------------------Desafio-------------------------
            try
            {
                Console.WriteLine("Inserte algun numero que sea divisible entre cero");
                string numeroInput = Console.ReadLine();
                int numDividir = int.Parse(numeroInput);
                int numCero = 0;
                int resultado = numDividir / 0;
                Console.WriteLine($"Su resultado fue: {numDividir} / {numCero} = {resultado}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ningun numero se puede dividir entre cero");
            }

            
            
            Console.Read();
        }
    }
}
