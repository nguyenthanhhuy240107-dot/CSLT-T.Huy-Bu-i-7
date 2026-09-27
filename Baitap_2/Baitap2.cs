using System;

namespace Baitap_2
{
    internal class Baitap2
    {
        //Hàm Bubble Sort
        static void Bubblesort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                    }
                }
            }
        }

        //Hàm Linear Search
        static int LinearSearch(string[] tim, string target)
        {
            for (int i = 0; i < tim.Length; i++)
            {
                if (tim[i].Equals(target, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }
        public static void Main(string[] args)
        {
            //1.
            int[] arr = new int[10];
            Console.WriteLine("Nhập 10 số nguyên:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Số thứ {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Bubblesort(arr);
            Console.WriteLine("\nMảng sau khi sắp xếp (Bubble Sort):");
            Console.WriteLine(string.Join(", ", arr));

            //2.
            Console.WriteLine("\nNhập một câu:");
            string cau = Console.ReadLine();

            Console.Write("Nhập từ cần tìm: ");
            string tu = Console.ReadLine();

            string[] tim = cau.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);

            int n = LinearSearch(tim, tu);

            if (n != -1)
                Console.WriteLine($"Từ \"{tu}\" xuất hiện tại vị trí {1 + n} trong câu.");
            else
                Console.WriteLine($"Từ \"{tu}\" không xuất hiện trong câu.");
        }
    }
}

