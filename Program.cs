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