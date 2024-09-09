
    internal class Program
    {
        static void Main(string[] args)
        {
            

        int filas, nfilas, colum, ncolum;

        Console.WriteLine("Lista de elementos de la Matriz");

        Console.WriteLine("Ingrese la cantidad de filas: ");
        nfilas = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de columas: ");
        ncolum = int.Parse(Console.ReadLine());

        int[,] matriz = new int[nfilas, ncolum];

        Console.WriteLine("Ingreso de datos");
        Console.WriteLine();
        for(filas = 0; filas < nfilas; filas++)
        {
            for(colum = 0; colum < ncolum; colum++)
            {
                Console.Write("Matriz[" + filas + ", " + colum + "] = ");
                matriz[filas, colum] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Inpresion de la matriz");
        
        for (filas = 0; filas < nfilas; filas++)
        {
            for (colum = 0; colum < ncolum; colum++)
            {
                Console.Write(matriz[filas, colum]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.ReadKey();
    }
}

