

public class Program
{
    //Lea la longitud de tres segmentos y que muestre si se puede construir un triángulo con estos segmentos.
    private static void Main(string[] args)
    {
        // declarando la variables pidiendolas por consola
        // declarar las variables; para este ejerciocio son 4:
        int lado1, lado2, lado3, suma;
        Console.WriteLine("por favor ingrese los centrimetros del lado 1:");
        lado1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("por favor ingrese los centrimetros del  lado 2:");
        lado2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("por favor ingrese los centrimetros del  lado 3:");
        lado3 = Convert.ToInt16(Console.ReadLine());
        //asignando a la variable suma los valores de lado 1 y lado 2
        suma = lado1 + lado2;
        //implementació de un condicional, donde me valida los datos ingresados
        if (suma > lado3)
        {
            Console.WriteLine($"La longitud de los lados :\n lado 1 y lado 2 forman un triangulo");
        }
        else
        {
            if (suma == lado3)
            {
                Console.WriteLine($"la longitud del lado 3:\n {lado3} es igual a la suma de los lados 1 y 2 \n, su suma no forman un triangulo");
            }
            else
            {
                Console.WriteLine($"la longitud del lado 3:\n {lado3} es mayor a la suma de los lados 1 y 2 \n, su suma no forman un triangulo");
            }

        }
    }
}