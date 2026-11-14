using System;

class Program
{
    static void Main(string[] args)
    {

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("=== Bài 1 ===");
        Bai1();
        Console.WriteLine("=== Bài 2 ===");
        Bai2();
        Console.WriteLine("=== Bài 3 ===");
        Bai3();
        Console.WriteLine("=== Bài 4 ===");
        Bai4();
        Console.WriteLine("=== Bài 5 ===");
        Bai5();

    }

    static void Bai1()
    {
        int n = 1000;
        int[] arr = new int[n];
        Random rand = new Random();

        for (int i = 0; i < n; i++)
        {
            arr[i] = rand.Next(0, 10001);
        }

        int maxval = arr[0];
        int minval = arr[0];
        for (int i = 1; i < n; i++)
        {
            if (arr[i] > maxval)
            {
                maxval = arr[i];
            }
            if (arr[i] < minval)
            {
                minval = arr[i];
            }
        }
        Console.WriteLine("Max value: " + maxval);
        Console.WriteLine("Min value: " + minval);


    }
    static void Bai2()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else
            {
                Console.WriteLine(i);
            }

        }
    }
    static void Bai3()
    {
        string? input = Console.ReadLine();
        Console.Write("Nhập vào một chuỗi bất kỳ: ");
        
        char[] charArray = input.ToCharArray();

        Array.Reverse(charArray);

        string reversedString = new string(charArray);
        Console.WriteLine("Chuỗi sau khi đảo ngược: " + reversedString);
    }


    static void Bai4()
    {
        int n = 20;
        int[] arr = new int[n];
        Random rand = new Random();

        for (int i = 0; i < n; i++)
        {
            arr[i] = rand.Next(0, 21);
        }
        Console.WriteLine("a. Mảng ban đầu:");
        Console.WriteLine(string.Join(", ", arr));

        Array.Sort(arr);
        Console.WriteLine("b. Mảng sau khi sắp xếp tăng dần:");
        Console.WriteLine(string.Join(", ", arr));

    }
    
      static void Bai5()
    {
        int n = 10; // Ví dụ tìm số Fibonacci thứ 10
        long fn = 0;

        if (n <= 0)
        {
            Console.WriteLine("Vui lòng nhập số nguyên dương lớn hơn 0.");
            return;
        }

        long f0 = 0; // Số Fibonacci thứ 1
        long f1 = 1; // Số Fibonacci thứ 2

        if (n == 1) fn = f0;
        else if (n == 2) fn = f1;
        else
        {
        // Vòng lặp tính từ số Fibonacci thứ 3 đến n
        for (int i = 3; i <= n; i++)
            {
                fn = f0 + f1; // Số hiện tại bằng tổng 2 số đứng trước nó
             f0 = f1;      // Dịch chuyển f0 lên f1
                f1 = fn;      // Dịch chuyển f1 lên fn
            }
        }

        Console.WriteLine($"Số Fibonacci thứ {n} là: {fn}");
    }
}
    
