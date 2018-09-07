using System;

namespace Division_con_modulo
{
    class Program
    {
        static void Main()
        {
            int num1 = 20, num2 = 5, num3 = 6, respuesta;
            respuesta = (num1 + num2) % num3;
            Console.WriteLine("El modulo de la operacion es: " + respuesta);
            Console.ReadKey();
        }
    }
}
