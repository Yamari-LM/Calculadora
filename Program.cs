using System;

class Operaciones
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("//Bienvenido al sistema de Calculadora LISETH//");
            Console.WriteLine("");
            Console.WriteLine("//Estas son Las del Sistema");
            Console.WriteLine("1. Dividir");
            Console.WriteLine("2. Multiplicar");
            Console.WriteLine("3. Sumar");
            Console.WriteLine("4. Restar");
            Console.WriteLine("5. Salir");
            

            Console.Write("Selecciona una operación : ");
            string opcion = Console.ReadLine();

            if (opcion == "5")
            {
                Console.WriteLine("Saliendo del programa...");
                break;
            }

            Console.Write("Ingresa un número: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Error: Por favor ingresa un número válido.");
                continue;
            }

            Console.Write("Ingresa el segundo número: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Error: Por favor ingresa un número válido.");
                continue;
            }

            double resultado = 0;
            bool operacionValida = true;

            if (opcion == "1")
            {
                resultado = num1 + num2;
            }
            else if (opcion == "2")
            {
                resultado = num1 - num2;
            }
            else if (opcion == "3")
            {
                resultado = num1 * num2;
            }
            else if (opcion == "4")
            {
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: División por cero no permitida.");
                    operacionValida = false;
                }
            }
            else
            {
                Console.WriteLine("Opción no válida, intenta de nuevo.");
                operacionValida = false;
            }

            if (operacionValida)
            {
                Console.WriteLine($"Resultado: {resultado}");
            }
        }
    }
}
