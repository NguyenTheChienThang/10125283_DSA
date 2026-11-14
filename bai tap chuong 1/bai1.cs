using System;

class Program
{
    static void Main(string[] args)
    {
        // Hỗ trợ hiển thị tiếng Việt trên Console
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int n = 1000;
        int[] arr = new int[n];
        Random rand = new Random();

        // 1. Nhập ngẫu nhiên 1000 số tự nhiên (ví dụ từ 0 đến 10000)
        for (int i = 0; i < n; i++)
        {
            arr[i] = rand.Next(0, 10001); 
        }

        Console.WriteLine($"=== Đã tạo ngẫu nhiên {n} số tự nhiên thành công ===");

        // 2. Tìm số lớn nhất (a) và số nhỏ nhất (b)
        int maxVal = arr[0];
        int minVal = arr[0];

        for (int i = 1; i < n; i++)
        {
            if (arr[i] > maxVal)
            {
                maxVal = arr[i];
            }
            if (arr[i] < minVal)
            {
                minVal = arr[i];
            }
        }

        // 3. In kết quả ra màn hình
        Console.WriteLine($"a. Số lớn nhất trong mảng là: {maxVal}");
        Console.WriteLine($"b. Số nhỏ nhất trong mảng là: {minVal}");
        
        // In thử 10 số đầu tiên để kiểm chứng mảng
        Console.Write("10 phần tử đầu tiên của mảng: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}