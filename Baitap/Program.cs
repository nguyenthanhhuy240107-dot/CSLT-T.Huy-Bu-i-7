using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    internal class Program
    {
        //tính giá trị trung bình của các phần tử trong mảng.
        static double TrungBinh(int[] a)
        {
            int t = 0;
            for (int i = 0; i < a.Length; i++)
            {
                t += a[i];
            } return t;
        }
        //kiểm tra xem mảng có chứa một giá trị cụ thể hay không.
        static bool KiemTra(int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                {
                    return true;
                }
            } return false;
        }
        //tìm chỉ số (vị trí) của một phần tử trong mảng.
        static int TimChiSo(int[] a, int x)
        {
            int min = 0;
            int max = x;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (x == a[mid])
                {
                    return ++mid;
                }
                else if (x < a[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
        //loại bỏ một phần tử cụ thể khỏi mảng.
        static int BoPhanTu(int[] a, int n)
        {

        }
        public static void Main(string[] args)
        {
            Console.Write("So luong: ");
            int n=int.Parse(Console.ReadLine());

            int[]a=new int[n];
            Random r =new Random();
            for (int i = 0;i < n; i++)
            {
                a[i] = r.Next(1, 100);
            }
            for (int i = 0;i< a.Length; i++)
            {
                Console.Write($"{a[i]}, ");
            }
            double tb =TrungBinh(a);
            Console.WriteLine($"\nGia tri TB = {tb}");

            Console.Write("Tim: ");
            int x= int.Parse(Console.ReadLine());
            if (KiemTra(a,x))
            {
                Console.WriteLine("Co chua gia tri");
            }
            else
            {
                Console.WriteLine("Khong chua gia tri");
            }
            Console.WriteLine($"Vi tri: {TimChiSo(a,x)}");


        }
    }
}
