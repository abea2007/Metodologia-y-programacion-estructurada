

public class Program
{
    static void Main(string[] args)
    {
        // Inicializamos el arreglo 
        int[] sumas = new int[13]; // La suma mínima es 2 y la máxima es 12.

        Random rand = new Random();
        int totalTiradas = 36000;

        // Tirar los dados 36,000 veces
        for (int i = 0; i < totalTiradas; i++)
        {
            int dado1 = rand.Next(1, 7); // Random entre 1 y 6 
            int dado2 = rand.Next(1, 7); // Random entre 1 y 6 
            int suma = dado1 + dado2; // Sumar los valores de los dos dados

            // Incrementar el contador de la suma correspondiente
            sumas[suma]++;
        }

        // imprimir los resultados
        Console.WriteLine("Suma\tFrecuencia\tProbabilidad");
        for (int i = 2; i <= 12; i++)
        {
            double probabilidad = (double)sumas[i] / totalTiradas;
            Console.WriteLine($"{i}\t{sumas[i]}\t\t{probabilidad:P2}");
        }

        // Comprobar si los resultados son razonables para la suma 7
        Console.WriteLine("\nVerificación de la suma 7:");
        Console.WriteLine($"Frecuencia de 7: {sumas[7]}");
        Console.WriteLine($"Esperado (aproximadamente 1/6): {(1.0 / 6.0) * totalTiradas}");
    }
}
