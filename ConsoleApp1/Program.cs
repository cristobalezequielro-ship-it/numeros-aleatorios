using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int numeroSecreto = new Random().Next(1, 101); // Número aleatorio entre 1 y 100
        int intentos = 0;
        bool haGanado = false;

        Console.WriteLine("Dame un número :)");
        Console.WriteLine("Adivina el numero secreto entre 1 y 100");

        while (!haGanado)
        {
            Console.Write("Introduce tu intento: ");
            string? entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int intento))
            {
                intentos++;
                if (intento < numeroSecreto)
                {
                    Console.WriteLine("Frío");
                }
                else if (intento > numeroSecreto)
                {
                    Console.WriteLine("Muy frío!");
                }
                else
                {
                    haGanado = true;
                    Console.WriteLine($"¡Felicidades! Has adivinado el numero {numeroSecreto} en {intentos} intentos.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número válido.");
            }
        }

        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
