namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[] array = { 4, 2, 7, 1, 5, 9, 3 };
                int target = 10;

                bool found = false;

                for (int i = 0; i < array.Length - 2; i++)
                {
                    int firstNumber = array[i];
                    for (int j = i + 1; j < array.Length - 1; j++)
                    {
                        int secondNumber = array[j];
                        for (int k = j + 1; k < array.Length; k++)
                        {
                            int thirdNumber = array[k];
                            if (firstNumber + secondNumber + thirdNumber == target)
                            {
                                Console.WriteLine($"Найдены три числа: {firstNumber} + {secondNumber} + {thirdNumber}");
                                found = true;
                            }
                        }
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Таких чисел в массиве нет");
                }
            }
        }
    }
}
