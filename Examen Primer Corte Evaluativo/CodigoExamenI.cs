using System;

public class program
{
    static void Main(string[] args)
    {
        // pido al usuario que ingrese al menos 3 nombres de estudiantes
        int n;
        do
        {
            Console.Write("Ingrese la cantidad de estudiantes (mínimo 3): ");
            n = int.Parse(Console.ReadLine());
        } while (n < 3);

        // 2. creo un arreglo unidimensional para manejar los nombres de los estudiantes
        string[] nombres = new string[n];

        // 3. creo matriz bidimensional para manejar las notas de los estudiantes (n estudiantes, 3 evaluaciones)
        float[,] notas = new float[n, 3];

        // pido al usuario que ingrese cada uno de los nombres de los estudiantes. Utilizo una iteración for
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Ingrese el nombre del estudiante {i + 1}: ");
            nombres[i] = Console.ReadLine();

            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Ingrese la nota del examen {j + 1} para {nombres[i]}: ");
                notas[i, j] = float.Parse(Console.ReadLine());
            }
        }

        // 4. variables para calcular la mayor nota y al mejor estudiante
        float mayorNotaFinal = 0;
        string mejorEstudiante = "";

        // esto lo hago para que los encabezdos siempre esten alineados
        Console.WriteLine("\n-------------------------------------------------------------");
        Console.WriteLine($"{"Estudiante",-15} {"Nota 1",7} {"Nota 2",7} {"Nota 3",7} {"Promedio",9} {"Estado",10}");
        Console.WriteLine("-------------------------------------------------------------");

        for (int i = 0; i < n; i++)
        {
            float sumaNotas = 0;
            for (int j = 0; j < 3; j++)
            {
                sumaNotas += notas[i, j];
            }

            float promedio = sumaNotas / 3;
            string estado = promedio >= 70 ? "Aprobado" : "Reprobado";

            // de igual manera imprimo los datos de manera alineada para una mejor estetica 
            Console.WriteLine($"{nombres[i],-15} {notas[i, 0],7:F2} {notas[i, 1],7:F2} {notas[i, 2],7:F2} {promedio,9:F2} {estado,10}");

            // 5. determino al mejor estudiante, es decir, el que tiene mayor promedio
            if (promedio > mayorNotaFinal)
            {
                mayorNotaFinal = promedio;
                mejorEstudiante = nombres[i];
            }
        }

        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine($"\nEl estudiante con mayor promedio es {mejorEstudiante} con un promedio de {mayorNotaFinal:F2}");
    }
}
