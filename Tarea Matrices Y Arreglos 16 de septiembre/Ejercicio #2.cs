 public class program 
{
    static void Main(string[] args)
    {
        // Arreglo de 10 asientos
        bool[] asientos = new bool[10];
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Por favor, elija una opción:");
            Console.WriteLine("1 para 'fumador'");
            Console.WriteLine("2 para 'no fumador'");
            int eleccion = int.Parse(Console.ReadLine());

            if (eleccion == 1)
            {
                // asignar en la sección de fumadores 
                if (AsignarAsiento(asientos, 0, 5))
                {
                    Console.WriteLine("Asiento asignado en la sección de fumadores.");
                }
                else
                {
                    // preguntar si desea asignar en la sección de no fumadores si la de fumadores está llena
                    Console.WriteLine("La sección de fumadores está llena. ¿Desea ser asignado en la sección de no fumadores? (s/n)");
                    string respuesta = Console.ReadLine();
                    if (respuesta.ToLower() == "s")
                    {
                        if (AsignarAsiento(asientos, 5, 10))
                        {
                            Console.WriteLine("Asiento asignado en la sección de no fumadores.");
                        }
                        else
                        {
                            Console.WriteLine("El próximo vuelo sale en 3 horas.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Next flight leaves in 3 hours.");
                    }
                }
            }
            else if (eleccion == 2)
            {
                // Intentar asignar en la sección de no fumadores (asientos 6 a 10)
                if (AsignarAsiento(asientos, 5, 10))
                {
                    Console.WriteLine("Asiento asignado en la sección de no fumadores.");
                }
                else
                {
                    // Preguntar si desea asignar en la sección de fumadores si la de no fumadores está llena
                    Console.WriteLine("La sección de no fumadores está llena. ¿Desea ser asignado en la sección de fumadores? (s/n)");
                    string respuesta = Console.ReadLine();
                    if (respuesta.ToLower() == "s")
                    {
                        if (AsignarAsiento(asientos, 0, 5))
                        {
                            Console.WriteLine("Asiento asignado en la sección de fumadores.");
                        }
                        else
                        {
                            Console.WriteLine("El próximo vuelo sale en 3 horas.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("El proximo vuelo sale en tres horas");
                    }
                }
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }

            // Verificar si todos los asientos están llenos
            if (VerificarVueloLleno(asientos))
            {
                Console.WriteLine("Todos los asientos están ocupados. El próximo vuelo sale en 3 horas.");
                break;
            }

            Console.WriteLine("¿Desea hacer otra reservación? (s/n)");
            string continuarRespuesta = Console.ReadLine();
            if (continuarRespuesta.ToLower() != "s")
            {
                continuar = false;
            }
        }
    }

    // Función para asignar un asiento en el rango especificado
    static bool AsignarAsiento(bool[] asientos, int inicio, int fin)
    {
        for (int i = inicio; i < fin; i++)
        {
            if (!asientos[i])
            {
                asientos[i] = true; // Asiento asignado
                Console.WriteLine($"Asignación exitosa. Su número de asiento es {i + 1}.");
                return true;
            }
        }
        return false; // No hay asientos disponibles en la sección
    }

    // Función para verificar si todos los asientos están llenos
    static bool VerificarVueloLleno(bool[] asientos)
    {
        foreach (bool asiento in asientos)
        {
            if (!asiento)
            {
                return false; // Todavía hay asientos disponibles
            }
        }
        return true; // Todos los asientos están ocupados
    }
}
