public class Program
{
    private static void Main(string[] args)
    {
        int contador = 0;
        int num;
        bool bandera = true;
        while (bandera)
        {
            Console.WriteLine("ingrese un numero:");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)
            {
                contador++;
            }
            else
            {
                bandera = false;
            }
        }
        Console.WriteLine($"el total de numeros positivos ingresados es de:{contador}");
    }
}