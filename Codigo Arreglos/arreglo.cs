 internal class Program
 {
     static void Main(string[] args)
     {
     int i;
     int nelementos;

     Console.WriteLine("Lista de elementos del arreglo");
     Console.WriteLine("Ingrese la cantidad de elementos del arreglo: ");
     nelementos = int.Parse(Console.ReadLine());

     int[] arreglo = new int[nelementos];

     for (i = 0; i < nelementos; i++)
     {
         Console.Write("Arreglo[" + i + "] = ");
         arreglo[i] = int.Parse(Console.ReadLine());

     }

     Console.WriteLine("Impresion de los datos");

     for(i = 0; i < nelementos ; i++)
     {
         Console.WriteLine(arreglo[i]);
     }
     Console.WriteLine();
     Console.ReadKey();
     }
 }

