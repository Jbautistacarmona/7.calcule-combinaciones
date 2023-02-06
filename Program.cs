using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.calcule_combinaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de combinaciones"); //mensaje para el usuario.
            Console.WriteLine("Con repetición (1) o sin repetición (2)?");
            int option = Convert.ToInt32(Console.ReadLine()); //Convierte la representación en forma de cadena de un número en el entero de 32 bits con signo equivalente
            Console.WriteLine("Introduce el número de elementos (n):");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce la cantidad a elegir (k):");
            int k = Convert.ToInt32(Console.ReadLine()); //conveierte representación en forma de cadena de un número en el entero de 32 bits con signo equivalente.
            double result;

            if (option == 1) //selecciona una instrucción que se va a ejecutar en función del valor de una expresión booleana
            {
                result = CombinacionConRepeticion(n, k);
                Console.WriteLine("El número de combinaciones con repetición es: " + result);
            }
            else if (option == 2) //Es usada para ejecutar una instrucción o bloque de instrucciones solo si una condición es cumplida.
            {
                result = CombinacionSinRepeticion(n, k);
                Console.WriteLine("El número de combinaciones sin repetición es: " + result);
            }
            else
            {
                Console.WriteLine("Opción inválida");
            }

            Console.ReadLine();//imprime resultado
        }
        static double CombinacionConRepeticion(int n, int k) //Use el modificador static para declarar un miembro estático, que pertenece al propio tipo en lugar de a un objeto específico
        {
            return Factorial(n + k - 1) / (Factorial(k) * Factorial(n - 1));
        }

        static double CombinacionSinRepeticion(int n, int k) //Use el modificador static para declarar un miembro estático, que pertenece al propio tipo en lugar de a un objeto específico.
        {
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }

        static double Factorial(int number) //Use el modificador static para declarar un miembro estático, que pertenece al propio tipo en lugar de a un objeto específico
        {
            double result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}