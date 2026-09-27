using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    internal class Program
    {
        //TRUNG BÌNH
        static double TinhTB(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) sum += arr[i];
            return (double)sum / arr.Length;
        }
        //KIỂM TRA GIÁ TRỊ
        static bool KiemTra(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == value) return true;
            return false;
        }
        //TÌM VỊ TRÍ
        static int TimViTri(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == value) return i;
            return -1;
        }
        //XÓA PHẦN TỬ
        static int[] XoaPhanTu(int[] arr, int value)
        {
            int c = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] != value) c++;

            int[] MangMoi = new int[c];
            int idx = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] != value) MangMoi[idx++] = arr[i];

            return MangMoi;
        }
        //TÍNH MIN VÀ MAX
        static (int, int) MinAndMax(int[] arr)
        {
            int min = arr[0], max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }
            return (min, max);
        }
        //ĐẢO NGƯỢC 
        static int[] DaoNguoc(int[] arr)
        {
            int[] dao = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                dao[i] = arr[arr.Length - 1 - i];
            return dao;
        }
        //TÌM TRÙNG LẶP
        static int[] TimTrungLap(int[] arr)
        {
            bool[] v = new bool[arr.Length];
            int[] t = new int[arr.Length];
            int c = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (v[i]) continue;
                int f = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        v[j] = true;
                        f++;
                    }
                }
                if (f > 1)
                {
                    t[c++] = arr[i];
                }
            }

            int[] lap = new int[c];
            Array.Copy(t, lap, c);
            return lap;
        }
        //XÓA TRÙNG LẶP
        static int[] XoaTrungLap(int[] arr)
        {
            int[] t = new int[arr.Length];
            int c = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool e = false;
                for (int j = 0; j < c; j++)
                {
                    if (arr[i] == t[j])
                    {
                        e = true;
                        break;
                    }
                }
                if (!e)
                {
                    t[c++] = arr[i];
                }
            }

            int[] result = new int[c];
            Array.Copy(t, result, c);
            return result;
        }
        
        public static void Main(string[] args)
        {
            Console.Write("Nhập số lượng phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());

            Random rand = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(1, 101);
            }

            Console.WriteLine($"Mảng ban đầu: {string.Join(", ", arr)}");

            // 1. Trung bình
            Console.WriteLine($"Giá trị trung bình: {TinhTB(arr)}");

            // 2. Kiểm tra giá trị
            Console.Write("Nhập giá trị cần kiểm tra: ");
            int valCheck = int.Parse(Console.ReadLine());
            Console.WriteLine($"Có chứa {valCheck}?: {KiemTra(arr, valCheck)}");

            // 3. Tìm chỉ số
            Console.Write("Nhập giá trị cần tìm chỉ số: ");
            int valFind = int.Parse(Console.ReadLine());
            Console.WriteLine($"Chỉ số của {valFind}: {TimViTri(arr, valFind)}");

            // 4. Xóa phần tử
            Console.Write("Nhập giá trị cần xóa: ");
            int valRemove = int.Parse(Console.ReadLine());
            int[] MangSauXoa = XoaPhanTu(arr, valRemove);
            Console.WriteLine($"Mảng sau khi xóa {valRemove}: {string.Join(", ", MangSauXoa)}");

            // 5. Min/Max
            var (min, max) = MinAndMax(arr);
            Console.WriteLine($"Giá trị nhỏ nhất = {min}, lớn nhất = {max}");

            // 6. Đảo ngược
            Console.WriteLine($"Mảng đảo ngược: {string.Join(", ", DaoNguoc(arr))}");

            // 7. Tìm trùng lặp
            Console.WriteLine($"Các giá trị trùng lặp: {string.Join(", ", TimTrungLap(arr))}");

            // 8. Loại bỏ trùng lặp
            Console.WriteLine($"Mảng sau khi loại bỏ trùng lặp: {string.Join(", ", XoaTrungLap(arr))}");
        }

    }


}