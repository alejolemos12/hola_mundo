public class Program
{
    //Lea la longitud de tres segmentos y que muestre si se puede construir un triángulo con estos segmentos.
    private static void Main(string[] args)
    {
        // declarando la variables pidiendolas por consola
        // declarar las variables; para este ejerciocio son 4:
        Double lado1, lado2, lado3, suma;
        bool istriangule;
        Console.WriteLine("por favor ingrese los centrimetros del lado 1:");
        lado1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("por favor ingrese los centrimetros del  lado 2:");
        lado2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("por favor ingrese los centrimetros del  lado 3:");
        lado3 = Convert.ToDouble(Console.ReadLine());
        //asignando a la variable suma los valores de lado 1 y lado 2
        suma = lado1 + lado2;
        //implementación de un condicional, donde me valida los datos ingresados
        if (suma > lado3 && lado3 +lado1>lado2 && lado2+ lado3>lado1)
        {
           istriangule = true;
            Console.WriteLine("los tres cegmentos  forman un triangulo");
        }
        else
        {
            istriangule=false;
            Console.WriteLine("los tres segmentos no forman un triangulo");
        


        }
    }
}