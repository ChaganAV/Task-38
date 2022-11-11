internal class Program
{
    private static void Main(string[] args)
    {
        int size = 5;
        double[] arrNum = new double[size];
        double minElem = 0;
        double maxElem = 0;
        Random rnd = new Random();

        for (int i = 0; i < arrNum.Length; i++)
        {
            arrNum[i] = rnd.NextDouble();
        }
        PrintArray(arrNum);

        /*for(int i = 0; i < arrNum.Length; i++)
        {
            if(i%2 == 0)
                sumNegative+= arrNum[i];
        }
        Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях  {sumNegative}");*/

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
            double min = 0;
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