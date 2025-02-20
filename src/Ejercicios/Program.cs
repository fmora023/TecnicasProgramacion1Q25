internal class Program
{
    /// <summary>
    /// Defines the entry point of the application.
    /// 
    ///  Suma de elementos [1,2,3] = 6 
    ///  Número máximo y mínimo[1, 2, 3] = Min:1 Max:2
    ///  Dividir una lista en sublistas(pares e impares) [1, 2, 3, 4] => [1, 3], [2, 4]
    /// </summary>
    /// <param name="args">The arguments.</param>
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        List<int> elementos = new List<int> { 1, 2, 3, 8, 5, 9, 11 };
        Console.WriteLine($"La suma de los elementos es: {SumaElementos(elementos)}");
        
        var maxMin = MaxMin(elementos);
        Console.WriteLine($"El numero maximo es : {maxMin.Item1} y el minimo es: {maxMin.Item2}");

        var paresImpares = ParesImparesEx(elementos);
        Console.WriteLine($"Pares: {string.Join(",", paresImpares.Pares)}");
        Console.WriteLine($"Impares: {string.Join(",", paresImpares.Impares)}");
    }

    private static int SumaElementos(List<int> elementos)
    {
        var result = 0;
        foreach (int elemento in elementos)
        {
            result += elemento;
        }
        return result;
    }

    public static (int, int) MaxMin(List<int> input)
    {
        if (input.Count == 0)
        {
            return (0, 0);
        }

        var min = input[0];
        var max = input[0];
        foreach (var element in input)
        {
            if (element > min)
            {
                min = element;
            }
            if (element < max)
            {
                max = element;
            }
        }

        return (max, min);
    }

    public static ParesImparesResult ParesImparesEx(List<int> input)
    {
        var result = new ParesImparesResult();

        foreach(var element in input)
        {
            if (element % 2 == 0)
            {
                result.Pares.Add(element);
            }
            else
            {
                result.Impares.Add(element);
            }
        }

        return result;
    }

    public class ParesImparesResult
    {
        public List<int> Pares { get; set; } = new List<int>();
        public List<int> Impares { get; set; } = new List<int>();
    }

}