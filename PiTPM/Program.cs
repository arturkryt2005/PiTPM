using System;

class Program
{
    static void Main()
    {
        int N = 10;
        double[] array = new double[N + 1];
        Random random = new Random();

        for (int i = 0; i <= N; i++)
        {
            array[i] = random.NextDouble() * 10;
        }

        double maxNech = double.MinValue;
        int chetCount = 0; // Счетчик четных чисел


        for (int i = 0; i <= N; i++)
        {
            Console.WriteLine(array[i]);
            if (array[i] % 2 != 0)
            {
                if (array[i] > maxNech)
                {
                    maxNech = array[i];
                }
            }
            else
            {
                chetCount++;
            }
        }
        Console.WriteLine("Наибольшее нечетное число: " + maxNech);
        Console.WriteLine("Количество четных чисел: " + chetCount);
    }
}
