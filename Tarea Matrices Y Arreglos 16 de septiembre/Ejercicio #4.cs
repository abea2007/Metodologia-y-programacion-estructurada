
public class program
{
    static void Main(string[] args)
    {
        
        int[] rangosSalarios = new int[9];

        // Variable para almacenar las ventas brutas de cada vendedor.
        double ventasBrutas;

        // Proceso para leer las ventas y calcular los salarios de los vendedores.
        while (true)
        {
            Console.Write("Ingrese las ventas brutas del vendedor (o -1 para terminar): ");
            ventasBrutas = double.Parse(Console.ReadLine());

            // Verificar si el usuario desea terminar el ingreso de datos.
            if (ventasBrutas == -1)
                break;

            // Calcular el salario del vendedor (200 más el 9% de las ventas brutas).
            double salario = 200 + (0.09 * ventasBrutas);

            // Convertir el salario a un valor entero (truncado).
            int salarioEntero = (int)salario;

            // Determinar en qué rango cae el salario.
            if (salarioEntero >= 200 && salarioEntero <= 299)
            {
                rangosSalarios[0]++;
            }
            else if (salarioEntero >= 300 && salarioEntero <= 399)
            {
                rangosSalarios[1]++;
            }
            else if (salarioEntero >= 400 && salarioEntero <= 499)
            {
                rangosSalarios[2]++;
            }
            else if (salarioEntero >= 500 && salarioEntero <= 599)
            {
                rangosSalarios[3]++;
            }
            else if (salarioEntero >= 600 && salarioEntero <= 699)
            {
                rangosSalarios[4]++;
            }
            else if (salarioEntero >= 700 && salarioEntero <= 799)
            {
                rangosSalarios[5]++;
            }
            else if (salarioEntero >= 800 && salarioEntero <= 899)
            {
                rangosSalarios[6]++;
            }
            else if (salarioEntero >= 900 && salarioEntero <= 999)
            {
                rangosSalarios[7]++;
            }
            else if (salarioEntero >= 1000)
            {
                rangosSalarios[8]++;
            }
        }

        // Mostrar los resultados de los contadores de los rangos.
        Console.WriteLine("\nDistribución de salarios:");
        Console.WriteLine($"1. $200 - $299: {rangosSalarios[0]} vendedores");
        Console.WriteLine($"2. $300 - $399: {rangosSalarios[1]} vendedores");
        Console.WriteLine($"3. $400 - $499: {rangosSalarios[2]} vendedores");
        Console.WriteLine($"4. $500 - $599: {rangosSalarios[3]} vendedores");
        Console.WriteLine($"5. $600 - $699: {rangosSalarios[4]} vendedores");
        Console.WriteLine($"6. $700 - $799: {rangosSalarios[5]} vendedores");
        Console.WriteLine($"7. $800 - $899: {rangosSalarios[6]} vendedores");
        Console.WriteLine($"8. $900 - $999: {rangosSalarios[7]} vendedores");
        Console.WriteLine($"9. $1000 o superior: {rangosSalarios[8]} vendedores");
    }
}
