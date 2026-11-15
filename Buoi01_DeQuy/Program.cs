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
            // CHƯƠNG 2: THUẬT TOÁN & ĐÁNH GIÁ ĐỘ PHỨC TẠP
            // =========================================================================
            Console.WriteLine("\n>>> CHƯƠNG 2: THUẬT TOÁN & ĐÁNH GIÁ ĐỘ PHỨC TẠP");
            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("=== Bài 1: Bài toán Tháp Hà Nội (4 đĩa) ===");
            C2_Bai1();

            Console.WriteLine("\n=== Bài 2: Tìm kiếm nhị phân ===");
            C2_Bai2();

            Console.WriteLine("\n=== Bài 3: Kiểm tra số nguyên tố tối ưu ===");
            C2_Bai3();

            Console.WriteLine("\n=== Bài 4: Liệt kê các số hoàn hảo nhỏ hơn N (2 giải thuật) ===");
            C2_Bai4();

            Console.WriteLine("\n=== Bài 5: Giải thuật tính Fibonacci ===");
            C2_Bai5();

            Console.WriteLine("\n=== Bài 6: Sắp xếp dãy số & So sánh thời gian chạy ===");
            C2_Bai6();

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
            Random rd = new Random(283);
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
            int dem = 0, n = 4;
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
            int n = 83;
            bool isPrime = true;
            if (n < 2) isPrime = false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) { isPrime = false; break; }
            }
            Console.WriteLine($"Số {n} có phải số nguyên tố không? {isPrime}");
        }

        // BÀI 4 RIÊNG: Liệt kê các số hoàn hảo nhỏ hơn N (2 giải thuật)
        static void C2_Bai4()
        {
            int N = 1000;
            Console.WriteLine($"Tìm các số hoàn hảo nhỏ hơn {N}:");

            // Giải thuật 1: Duyệt ước từ 1 đến k/2 - O(N^2)
            Console.Write("Giải thuật 1 (Cơ bản): ");
            for (int k = 2; k < N; k++)
            {
                int tongUoc = 0;
                for (int i = 1; i <= k / 2; i++)
                    if (k % i == 0) tongUoc += i;
                if (tongUoc == k) Console.Write(k + " ");
            }
            Console.WriteLine();

            // Giải thuật 2: Duyệt ước đến căn bậc 2 của k - O(N * sqrt(N))
            Console.Write("Giải thuật 2 (Tối ưu): ");
            for (int k = 2; k < N; k++)
            {
                if (LaSoHoanHaoToiUu(k)) Console.Write(k + " ");
            }
            Console.WriteLine();

            static bool LaSoHoanHaoToiUu(int k)
            {
                if (k < 2) return false;
                int tong = 1;
                for (int i = 2; i * i <= k; i++)
                {
                    if (k % i == 0)
                    {
                        tong += i;
                        if (i * i != k) tong += k / i;
                    }
                }
                return tong == k;
            }
        }

        static void C2_Bai5()
        {
            int n = 9;
            Console.WriteLine($"Fibonacci đệ quy tại vị trí {n}: {FibRec(n)}");

            static long FibRec(int n) => (n <= 1) ? n : FibRec(n - 1) + FibRec(n - 2);
        }

        // BÀI 6 RIÊNG: Sắp xếp dãy số & So sánh thời gian thực thi
        static void C2_Bai6()
        {
            Random rd = new Random(283);
            int[] arrMau = new int[10];
            for (int i = 0; i < arrMau.Length; i++) arrMau[i] = rd.Next(1, 100);

            Console.WriteLine("Mảng mẫu ban đầu: " + string.Join(" ", arrMau));
            int[] arrSorted = (int[])arrMau.Clone();
            SelectionSort(arrSorted);
            Console.WriteLine("Mảng sau sắp xếp chọn: " + string.Join(" ", arrSorted));

            // Đo thời gian chạy thực nghiệm với n = 3000
            int n = 3000;
            int[] data = new int[n];
            for (int i = 0; i < n; i++) data[i] = rd.Next(1, 100000);

            int[] a1 = (int[])data.Clone();
            Stopwatch sw = Stopwatch.StartNew();
            SelectionSort(a1);
            sw.Stop();
            long tSelection = sw.ElapsedMilliseconds;

            int[] a2 = (int[])data.Clone();
            sw.Restart();
            Array.Sort(a2); // QuickSort/IntroSort chuẩn của C#
            sw.Stop();
            long tQuick = sw.ElapsedMilliseconds;

            Console.WriteLine($"So sánh với n = {n}: SelectionSort = {tSelection} ms | QuickSort = {tQuick} ms");

            static void SelectionSort(int[] a)
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    int minIdx = i;
                    for (int j = i + 1; j < a.Length; j++)
                        if (a[j] < a[minIdx]) minIdx = j;
                    int temp = a[i];
                    a[i] = a[minIdx];
                    a[minIdx] = temp;
                }
            }
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