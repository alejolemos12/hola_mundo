public class Program
{
    private static void Main(string[] args)
    {
        //Construir un programa que pida por pantalla 3 números y luego diga cuál es elmayor,
        //el del medio y el menor de los números ingresados.
        int num1, num2, num3;
        Console.WriteLine("ingrese valor de numero 1");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese valor de numero 2");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese valor de numero 3");
        num3 = int.Parse(Console.ReadLine());
        int medio, menor, mayor;
        if (num1 > num2 && num1 > num3)
        {
            mayor = num1;
            Console.WriteLine($" el numero {mayor} es mayor a:" + num2 + " y " + num3);
        }
        else if (num2 > num3)
        {
            mayor = num2;
        }
        else
        {
            medio = num3;
            menor = num2;
        }
        if (num2 >= num1 && num2 >= num3)
        {
            mayor = num2;
            // Encuentra el menor entre los otros dos
            if (num1 >= num3)
            {
                medio = num1;
                menor = num3;
            }
            else
            {
                medio = num3;
                menor = num1;
            }
        }
        else
        {
            mayor = num3;
            // Encuentra el menor entre los otros dos
            if (num1 >= num2)
            {
                medio = num1;
                menor = num2;
            }
            else
            {
                medio = num2;
                menor = num1;
            }
        }

        // Imprime los resultados
        Console.WriteLine($"El número mayor es {mayor}");
        Console.WriteLine($"El número del medio es {medio}");
        Console.WriteLine($"El número menor es {menor}");
    }
}
