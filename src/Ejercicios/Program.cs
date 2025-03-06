using Ejercicios;

/// <summary>
/// Entry point of the application.
/// </summary>
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
        Console.WriteLine($"La suma de los elementos es: {ClassTasks.SumaElementos(elementos)}");
        
        var maxMin = ClassTasks.MaxMin(elementos);
        Console.WriteLine($"El numero maximo es : {maxMin.Item1} y el minimo es: {maxMin.Item2}");

        var paresImpares = ClassTasks.ParesImparesEx(elementos);
        Console.WriteLine($"Pares: {string.Join(",", paresImpares.Pares)}");
        Console.WriteLine($"Impares: {string.Join(",", paresImpares.Impares)}");

        var ocurrencias = ClassTasks.OccurenciesCount("palabra");

        foreach (var item in ocurrencias)
        {
            Console.WriteLine($"La letra {item.Key} se repite {item.Value} veces");
        }

        Console.WriteLine(Environment.NewLine);
        Console.WriteLine(ClassTasks.RemoveChar("hola", 'a'));

        Console.WriteLine(Environment.NewLine);
        Console.WriteLine(ClassTasks.RemoveVocals("hOla"));

        var words = ClassTasks.CountWords("Contar palabras input: hola hola hi => expected: hola : 2, hi : 1");

        foreach (var item in words)
        {
            if (item.Value > 1)
            {
                Console.WriteLine($"La palabra {item.Key} se repite {item.Value} veces");
            }
            else
            {
                Console.WriteLine($"La palabra {item.Key} se repite {item.Value} vez");
            }
        }
    }

}