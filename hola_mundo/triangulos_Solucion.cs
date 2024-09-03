public class triangulos_Solucion
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
        //implementación de un condicional, donde me valida los datos ingresados
        if (suma > lado3)
        {
            Console.WriteLine($"la suma de los lados {lado1} y {lado2}:  forman un triangulo");
        }
        else { 
            Console.WriteLine($"la suma de los lados {lado1} y {lado2} :  no forman un triangulo por que  lado {lado3}:  tiene los mismo centimetros");
        }
    }
}