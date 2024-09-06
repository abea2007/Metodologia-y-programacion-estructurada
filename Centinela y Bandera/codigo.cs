

public class Program
{
    public static void Main(string[] args)
    {
        int n;
        char resp;

        Console.WriteLine("Uso de entrada con iteraciones");

        do
        {
            Console.WriteLine("Ingrese el numero: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Deswa ingresar otro numero (S=SI && N=NO: ");
            resp = char.Parse(Console.ReadLine());

          
           
        } while (resp == 'S' || resp == 'N');
        do
        {
            Console.WriteLine("Ingrese un numero (Digite -99 para finalizar)");
            n = int.Parse(Console.ReadLine());
        } while (n != -99);
        bool bandera = false;
        Console.WriteLine("Uso de bandera");
        do
        {
            Console.WriteLine("Ingrese un numero positivo: ");
            n = int.Parse(Console.ReadLine());

            if(n < 0)
            {
                bandera = true;
            }
        }while(bandera == false);


        // si se conoce el numero de interaciones entonces de arramqiue se va por el for. En cambio, si se descomnocen las interacipnes es el whiloe, pero si me piden una entrada de datos es un dowhile, si necesito una gstion de elemetnps de una coleccipomn me voy por el foreach
    }
}
