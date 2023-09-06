using System;

class ShellSort
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 7, 19, 4, 6 };

        Console.WriteLine("Масив перед сортуванням:");
        PrintArray(arr);

        Sort(arr);

        Console.WriteLine("\nМасив після сортування:");
        PrintArray(arr);
    }


    public static void Sort(int[] arr)
    {
        int n = arr.Length;

        int gap = n / 2;

        while (gap > 0)
        {
            for (int i = gap; i < n; i++)
            {
                int temp = arr[i];
                int j = i;

                while (j >= gap && arr[j - gap] > temp)
                {
                    arr[j] = arr[j - gap];
                    j -= gap;
                }

                arr[j] = temp;
            }

            gap /= 2;
        }
    }

    public static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
