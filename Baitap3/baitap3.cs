using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{
    internal class baitap3
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số hàng N: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột M: ");
            int M = int.Parse(Console.ReadLine());

            // Tạo ma trận ngẫu nhiên
            int[,] matrix = rdmatran(N, M);

            // In ma trận
            Console.WriteLine("\nMa trận ban đầu:");
            InMaTran(matrix);

            // Nhập chỉ số hàng-cột
            Console.Write("\nNhập chỉ số hàng i (0..N-1): ");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hàng {row+1}: ");
            Hang(matrix, row);

            Console.Write("\nNhập chỉ số cột i (0..M-1): ");
            int col = int.Parse(Console.ReadLine());
            Console.WriteLine($"Cột {col+1}: ");
            Cot(matrix, col);

            // Tìm max toàn ma trận
            Console.WriteLine("\nGiá trị lớn nhất của ma trận: " + MaxMaTran(matrix));

            // Tìm min của hàng-cột
            Console.WriteLine($"Giá trị nhỏ nhất của hàng {row}: {MinRow(matrix, row)}");
            Console.WriteLine($"Giá trị nhỏ nhất của cột {col}: {MinCol(matrix, col)}");

            // Chuyển vị
            Console.WriteLine("\nMa trận chuyển vị:");
            int[,] chuyenvi = ChuyenVi(matrix);
            InMaTran(chuyenvi);

            // Đường chéo chính-phụ nếu là ma trận vuông
            if (N == M)
            {
                Console.WriteLine("\nĐường chéo chính:");
                DgCheoChinh(matrix);

                Console.WriteLine("Đường chéo phụ:");
                DgCheoPhu(matrix);
            }
            else
            {
                Console.WriteLine("\nKhông thể in đường chéo vì ma trận không vuông.");
            }
        }

        static int[,] rdmatran(int N, int M)
        {
            Random rand = new Random();
            int[,] matrix = new int[N, M];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    matrix[i, j] = rand.Next(1, 101);
            return matrix;
        }

        static void InMaTran(int[,] matrix)
        {
            int N = matrix.GetLength(0);
            int M = matrix.GetLength(1);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                    Console.Write(matrix[i, j] + "\t");
                Console.WriteLine();
            }
        }

        static void Hang(int[,] matrix, int row)
        {
            int M = matrix.GetLength(1);
            for (int j = 0; j < M; j++)
                Console.Write(matrix[row, j] + " ");
            Console.WriteLine();
        }

        static void Cot(int[,] matrix, int col)
        {
            int N = matrix.GetLength(0);
            for (int i = 0; i < N; i++)
                Console.Write(matrix[i, col] + " ");
            Console.WriteLine();
        }

        static int MaxMaTran(int[,] matrix)
        {
            int maxVal = matrix[0, 0];
            foreach (int val in matrix)
                if (val > maxVal) maxVal = val;
            return maxVal;
        }

        static int MinRow(int[,] matrix, int row)
        {
            int M = matrix.GetLength(1);
            int minVal = matrix[row, 0];
            for (int j = 1; j < M; j++)
                if (matrix[row, j] < minVal) minVal = matrix[row, j];
            return minVal;
        }

        static int MinCol(int[,] matrix, int col)
        {
            int N = matrix.GetLength(0);
            int minVal = matrix[0, col];
            for (int i = 1; i < N; i++)
                if (matrix[i, col] < minVal) minVal = matrix[i, col];
            return minVal;
        }

        static int[,] ChuyenVi(int[,] matrix)
        {
            int N = matrix.GetLength(0);
            int M = matrix.GetLength(1);
            int[,] chuyenvi = new int[M, N];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    chuyenvi[j, i] = matrix[i, j];
            return chuyenvi;
        }

        static void DgCheoChinh(int[,] matrix)
        {
            int N = matrix.GetLength(0);
            for (int i = 0; i < N; i++)
                Console.Write(matrix[i, i] + " ");
            Console.WriteLine();
        }

        static void DgCheoPhu(int[,] matrix)
        {
            int N = matrix.GetLength(0);
            for (int i = 0; i < N; i++)
                Console.Write(matrix[i, N - 1 - i] + " ");
            Console.WriteLine();

        }

    }
}
