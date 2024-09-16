

public class program
{
    static void Main(string[] args)
    {
        // Inicialización del arreglo 
        double[,] ventas = new double[4, 5];

        // llenar el arreglo con los datos de ventas del mes
        Console.WriteLine("Ingrese los datos de ventas: ");
        for (int vendedor = 0; vendedor < 4; vendedor++)
        {
            Console.WriteLine($"Vendedor {vendedor + 1}:");
            for (int producto = 0; producto < 5; producto++)
            {
                Console.Write($"Producto {producto + 1}, monto vendido en dólares: ");
                ventas[vendedor, producto] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }

        // tabla de ventas
        Console.WriteLine("\nVentas Totales por Vendedor y Producto:");
        Console.WriteLine("=======================================");
        Console.WriteLine("           P1       P2       P3       P4       P5       Total");
        Console.WriteLine("==============================================================");

        for (int vendedor = 0; vendedor < 4; vendedor++)
        {
            double totalVendedor = 0;
            Console.Write($"Vendedor {vendedor + 1}: ");
            for (int producto = 0; producto < 5; producto++)
            {
                Console.Write($"{ventas[vendedor, producto],8} ");
                totalVendedor += ventas[vendedor, producto];
            }
            Console.WriteLine($"{totalVendedor,8}"); // Total por vendedor
        }

        // total por producto
        Console.WriteLine("==============================================================");
        Console.Write("Total    : ");
        for (int producto = 0; producto < 5; producto++)
        {
            double totalProducto = 0;
            for (int vendedor = 0; vendedor < 4; vendedor++)
            {
                totalProducto += ventas[vendedor, producto];
            }
            Console.Write($"{totalProducto,8} "); // Total por producto
        }
        Console.WriteLine();
    }
}
