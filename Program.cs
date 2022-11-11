internal class Program
{
    private static void Main(string[] args)
    {
        int size = 5;
        double[] arrDouble = new double[size];
        double minElem = 0;
        double maxElem = 0;
        Random rnd = new Random();

        for (int i = 0; i < arrDouble.Length; i++)
        {
            arrDouble[i] = rnd.NextDouble();
        }
        PrintArray(arrDouble);
        minElem = FindMinDouble(arrDouble);
        maxElem = FindMaxDouble(arrDouble);
        Console.WriteLine($"Минимальный {minElem}");
        Console.WriteLine($"Максимальный {maxElem}");
        Console.WriteLine($"Разница между макс и мин элементами массива {maxElem-minElem}");

        // Functions
        double FindMaxDouble(double[] array)
        {
            double max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }

        double FindMinDouble(double[] array)
        {
            double min = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;
        }

        void PrintArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
}