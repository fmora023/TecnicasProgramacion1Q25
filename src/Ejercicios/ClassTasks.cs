namespace Ejercicios
{
    /// <summary>
    /// Different examples of tasks made in class for quices and assings.
    /// </summary>
    public static partial class ClassTasks
    {
        /// <summary>
        /// Counts the words.
        /// Contar palabras input: "hola hola hi" => expected:"hola":2, "hi":1
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static Dictionary<string, int> CountWords(string input)
        {
            if (string.IsNullOrEmpty(input))  // input == null || input == ""
            {
                return new Dictionary<string, int>();
            }

            var words = input.Split(' ');
            var result = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!result.ContainsKey(word))
                {
                    result[word] = 1;
                }
                else
                {
                    result[word]++;
                }
            }

            return result;
        }

        /// <summary>
        /// Maximums the minimum.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Occurencieses the count.
        /// Contar ocurrencias de un elemento ejemplo: input:"palabra" => expected: p:1, a:3, l:1, b:1, r:1
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static Dictionary<string, int> OccurenciesCount(string input)
        {
            if (string.IsNullOrEmpty(input))  // input == null || input == ""
            {
                return new Dictionary<string, int>();
            }

            var result = new Dictionary<string, int>();

            foreach (var element in input)
            {
                if (!result.ContainsKey(element.ToString()))
                {
                    result[element.ToString()] = 1;
                }
                else
                {
                    result[element.ToString()]++;
                }
            }

            return result;
        }

        /// <summary>
        /// Pareses the impares ex.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static ParesImparesResult ParesImparesEx(List<int> input)
        {
            var result = new ParesImparesResult();

            foreach (var element in input)
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

        /// <summary>
        /// Removes the character.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="charToBeRemoved">The character to be removed.</param>
        /// <returns></returns>
        public static string RemoveChar(string input, char charToBeRemoved)
        {
            if (string.IsNullOrEmpty(input))  // input == null || input == ""
            {
                return string.Empty;
            }

            var result = string.Empty;
            foreach (var element in input)
            {
                if (element != charToBeRemoved)
                {
                    result += element;
                }
            }

            return result;
        }

        /// <summary>
        /// Removes the vocals.
        /// eliminar vocales input: "hola" => "hl"
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static string RemoveVocals(string input)
        {
            if (string.IsNullOrEmpty(input))  // input == null || input == ""
            {
                return string.Empty;
            }

            var vocals = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            var result = string.Empty;
            foreach (var element in input)
            {
                if (!vocals.Contains(element))
                {
                    result += element;
                }
            }

            return result;
        }

        /// <summary>
        /// Sumas the elementos.
        /// </summary>
        /// <param name="elementos">The elementos.</param>
        /// <returns></returns>
        public static int SumaElementos(List<int> elementos)
        {
            var result = 0;
            foreach (int elemento in elementos)
            {
                result += elemento;
            }
            return result;
        }

        /// <summary>
        /// Determines whether the specified input is palindrome.
        /// ana => true 
        /// casa => false
        /// annna => true
        /// abcdeedcba => true
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        ///   <c>true</c> if the specified input is palindrome; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="System.NotImplementedException">Part of the quiz is to implement this method</exception>
        public static bool IsPalindrome(string input)
        {
            // to be implemented.
            throw new NotImplementedException("Part of the quiz is to implement this method");
        }
    }
}
