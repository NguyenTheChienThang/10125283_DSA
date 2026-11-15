﻿using System;
using System.Diagnostics;

namespace _10125283_DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("============================================================");
            Console.WriteLine("     BÀI TẬP THỰC HÀNH CTDL> - CÁC CHƯƠNG");
            Console.WriteLine("     Họ tên: Nguyễn Thế Chiến Thắng - MSV: 10125283 - Lớp: 10125N.1");
            Console.WriteLine("============================================================\n");

            // =========================================================================
            // CHƯƠNG 1: ÔN TẬP C# & MẢNG
            // =========================================================================
            Console.WriteLine(">>> CHƯƠNG 1: ÔN TẬP C# & MẢNG");
            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("=== Bài 1: Tìm Max, Min trong mảng 500 số ngẫu nhiên ===");
            bai1_c1();

            Console.WriteLine("\n=== Bài 2: Trò chơi FizzBuzz (1 đến 20) ===");
            C1_Bai2();

            Console.WriteLine("\n=== Bài 3: Đảo ngược chuỗi cá nhân ===");
            C1_Bai3();

            Console.WriteLine("\n=== Bài 4: Sắp xếp mảng số nguyên ===");
            C1_Bai4();

            Console.WriteLine("\n=== Bài 5: Tính số Fibonacci thứ n ===");
            C1_Bai5();

            // =========================================================================
            // CHƯƠNG 2: THUẬT TOÁN & THÁP HÀ NỘI
            // =========================================================================
            Console.WriteLine("\n>>> CHƯƠNG 2: THUẬT TOÁN & THÁP HÀ NỘI");
            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("=== Bài 1: Bài toán Tháp Hà Nội (4 đĩa) ===");
            C2_Bai1();

            Console.WriteLine("\n=== Bài 2: Tìm kiếm nhị phân ===");
            C2_Bai2();

            Console.WriteLine("\n=== Bài 3: Kiểm tra số nguyên tố tối ưu ===");
            C2_Bai3();

            Console.WriteLine("\n=== Bài 4 & 6: Sắp xếp và đo thời gian thực thi ===");
            C2_Bai4Va6();

            Console.WriteLine("\n=== Bài 5: Giải thuật tính Fibonacci ===");
            C2_Bai5();

            // =========================================================================
            // CHƯƠNG 3: CÁC BÀI TOÁN ĐỆ QUY
            // =========================================================================
            Console.WriteLine("\n>>> CHƯƠNG 3: CÁC BÀI TOÁN ĐỆ QUY KINH ĐIỂN");
            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("=== Bài 1: Tính S(n) = 1 + 2 + ... + n ===");
            C3_Bai1();

            Console.WriteLine("\n=== Bài 2: Tính S(n) = 1^2 + 2^2 + ... + n^2 ===");
            C3_Bai2();

            Console.WriteLine("\n=== Bài 3: Tính S(n) = 1 + 1/2 + ... + 1/n ===");
            C3_Bai3();

            Console.WriteLine("\n=== Bài 4: Tính x^n ===");
            C3_Bai4();

            Console.WriteLine("\n=== Bài 5: Tìm ước số lẻ lớn nhất của n ===");
            C3_Bai5();

            Console.WriteLine("\n=== Bài 6: Tìm ước chung lớn nhất UCLN(a, b) ===");
            C3_Bai6();

            Console.WriteLine("\n=== Bài 7: Đếm số lượng chữ số của MSV ===");
            C3_Bai7();

            Console.WriteLine("\n=== Bài 8: Tính căn bậc 2 lồng nhau S(n) ===");
            C3_Bai8();

            Console.ReadKey();
        }

        #region CHƯƠNG 1
        static void bai1_c1()
        {
            int[] a = new int[500];
            Random rd = new Random(283); // Lấy đuôi MSV 283 tạo sự khác biệt
            for (int i = 0; i < 500; i++) a[i] = rd.Next(1, 5000);

            int max = a[0], min = a[0];
            for (int i = 1; i < 500; i++)
            {
                if (a[i] > max) max = a[i];
                if (a[i] < min) min = a[i];
            }
            Console.WriteLine("Giá trị lớn nhất: " + max);
            Console.WriteLine("Giá trị nhỏ nhất: " + min);
        }

        static void C1_Bai2()
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) Console.Write("FizzBuzz ");
                else if (i % 3 == 0) Console.Write("Fizz ");
                else if (i % 5 == 0) Console.Write("Buzz ");
                else Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void C1_Bai3()
        {
            string s = "NguyenTheChienThang_10125283";
            Console.WriteLine("Chuỗi gốc: " + s);
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine("Chuỗi đảo: " + new string(arr));
        }

        static void C1_Bai4()
        {
            int[] a = { 8, 3, 10, 2, 7, 1 };
            Console.WriteLine("Mảng ban đầu: " + string.Join(" ", a));
            Array.Sort(a);
            Console.WriteLine("Mảng sắp xếp tăng dần: " + string.Join(" ", a));
        }

        static void C1_Bai5()
        {
            int n = 8;
            Console.WriteLine($"Số Fibonacci thứ {n} là: {Fib(n)}");

            static long Fib(int n)
            {
                if (n <= 1) return n;
                long a = 0, b = 1;
                for (int i = 2; i <= n; i++)
                {
                    long c = a + b;
                    a = b;
                    b = c;
                }
                return b;
            }
        }
        #endregion

        #region CHƯƠNG 2
        static void C2_Bai1()
        {
            int dem = 0, n = 4; // Đổi số đĩa thành 4 để khác biệt
            HaNoi(n, 'A', 'B', 'C', ref dem);
            Console.WriteLine("Tổng số lần dịch chuyển tháp (4 đĩa): " + dem);

            static void HaNoi(int n, char A, char B, char C, ref int dem)
            {
                if (n == 1)
                {
                    dem++;
                    return;
                }
                HaNoi(n - 1, A, C, B, ref dem);
                dem++;
                HaNoi(n - 1, B, A, C, ref dem);
            }
        }

        static void C2_Bai2()
        {
            int[] a = { 2, 4, 6, 8, 10, 12, 16 };
            int x = 10;
            int idx = Array.BinarySearch(a, x);
            Console.WriteLine($"Tìm kiếm nhị phân phần tử {x} tại index: {idx}");
        }

        static void C2_Bai3()
        {
            int n = 83; // Lấy theo 283 của MSV
            bool isPrime = true;
            if (n < 2) isPrime = false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) { isPrime = false; break; }
            }
            Console.WriteLine($"Số {n} có phải số nguyên tố không? {isPrime}");
        }

        static void C2_Bai4Va6()
        {
            Stopwatch sw = Stopwatch.StartNew();
            int[] a = new int[2000];
            Random rd = new Random(283);
            for (int i = 0; i < 2000; i++) a[i] = rd.Next(1, 5000);
            Array.Sort(a);
            sw.Stop();
            Console.WriteLine($"Thời gian xử lý mảng 2000 phần tử: {sw.ElapsedMilliseconds} ms");
        }

        static void C2_Bai5()
        {
            int n = 9;
            Console.WriteLine($"Fibonacci đệ quy tại vị trí {n}: {FibRec(n)}");

            static long FibRec(int n) => (n <= 1) ? n : FibRec(n - 1) + FibRec(n - 2);
        }
        #endregion

        #region CHƯƠNG 3
        static void C3_Bai1()
        {
            int n = 6;
            Console.WriteLine($"S({n}) = 1 + 2 + ... + {n} = {S1(n)}");
            static int S1(int n) => n == 1 ? 1 : S1(n - 1) + n;
        }

        static void C3_Bai2()
        {
            int n = 4;
            Console.WriteLine($"S({n}) = 1^2 + ... + {n}^2 = {S2(n)}");
            static int S2(int n) => n == 1 ? 1 : S2(n - 1) + n * n;
        }

        static void C3_Bai3()
        {
            int n = 4;
            Console.WriteLine($"S({n}) = 1 + 1/2 + ... + 1/{n} = {S3(n):F4}");
            static double S3(int n) => n == 1 ? 1 : S3(n - 1) + 1.0 / n;
        }

        static void C3_Bai4()
        {
            double x = 3.0; int n = 3;
            Console.WriteLine($"{x}^{n} = {Math.Pow(x, n)}");
        }

        static void C3_Bai5()
        {
            int n = 30;
            Console.WriteLine($"Ước số lẻ lớn nhất của {n} là: {UocLe(n)}");
            static int UocLe(int n) => (n % 2 == 1) ? n : UocLe(n / 2);
        }

        static void C3_Bai6()
        {
            int a = 36, b = 60;
            Console.WriteLine($"UCLN({a}, {b}) = {UCLN(a, b)}");
            static int UCLN(int a, int b) => (a % b == 0) ? b : UCLN(b, a % b);
        }

        static void C3_Bai7()
        {
            long n = 10125283;
            Console.WriteLine($"Số {n} có {SoCS(n)} chữ số");
            static int SoCS(long n) => (n == 0) ? 0 : SoCS(n / 10) + 1;
        }

        static void C3_Bai8()
        {
            int n = 4;
            Console.WriteLine($"Căn bậc 2 lồng nhau S({n}) = {Can(1, n):F4}");
            static double Can(int i, int n) => (i == n) ? Math.Sqrt(n) : Math.Sqrt(i + Can(i + 1, n));
        }
        #endregion
    }
}