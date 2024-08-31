public class Program
{
       private static void Main(string[] args)
    {
        // declarar las variables; para este ejerciocio son 4:
        double x1, x2, y1, y2, d;
        //vamos a inicializar lass variable,pidiendolas por consola
        Console.WriteLine("por favor ingrese el valor de x1:");
        //console clase para invocar el metodo
        x1 = Convert.ToDouble(Console.ReadLine());// convertiendo x1 de string a double
        Console.WriteLine("por favor ingrese el valor de x2:");
        x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("por favor ingrese el valor de y1:");
        y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("por favor ingrese el valor de y2:");
        y2 = Convert.ToDouble(Console.ReadLine());

        // proceso--> caculo de la variable b, que hace referencia a los puntos
        double x = (x2 - x1) * (x2 - x1);
        double y = (y2 - y1) * (y2 - x1);

        double suma = x + y;
        // clase match tiene muchos metodos, aqui estamos elevando al cuadrado los datos que hay en suma
        d=Convert.ToDouble(Math.Sqrt(suma));
        // forma de concatenar : interpolacion
        Console.WriteLine($"la distancia entre los puntos ingresados es:{d}");


    }
}