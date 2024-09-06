/*Cálculo del precio con descuento. Escribe un programa que
calcule el precio final de un producto después de aplicar un
descuento según el tipo de cliente:
Cliente Regular: 10 % de descuento
Cliente VIP: 20 % de descuento
El programa debe pedir el precio original del producto y el tipo de
cliente (Regular o VIP) y mostrar el precio con descuento.*/

public class Program
{
    static void Main(string[] args)
    {
        string producto;
        float precio;
        const float descuento10 = 0.10f;
        const float descuento20 = 0.20f;
        char tipocliente;
        float total = 0;
        float subtotal;
        int cantidad;

        Console.WriteLine("Ingrese el nombre del producto");
        producto = Console.ReadLine();

        Console.WriteLine("Ingrese la cantidad del producto:");
        cantidad = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el precio original del producto:");
        precio = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el tipo de cliente VIP/REGULAR");
        tipocliente = char.Parse(Console.ReadLine());

        if (tipocliente == 'v' || tipocliente == 'V')
        {
            Console.WriteLine("El descuento aplicado es del 20%");
            subtotal = precio * cantidad;
            total = subtotal - (subtotal * descuento20);
        }
        else if(tipocliente == 'r' || tipocliente == 'R')
        {
            Console.WriteLine("El desceunto aplicado es del 10%");
            subtotal = precio * cantidad;
            total = subtotal - (subtotal * descuento10);
        }
        

        Console.WriteLine("El precio del producto es: {0} ", total);
        }
}
