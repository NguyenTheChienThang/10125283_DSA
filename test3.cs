using System;

public static class Units
{
    // Hàm phụ trợ tính giai thừa n!
    public static long GiaiThua(int n)
    {
        if (n < 0) return -1; // Không hợp lệ
        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    // 1. Tính giá trị y = căn bậc 3 của x
    public static double CanBacBa(double x)
    {
        return Math.Cbrt(x);
    }

    // 2. Tính Tổ hợp C(n, k)
    public static double ToHop(int n, int k)
    {
        if (k < 0 || k > n) return 0;
        return (double)GiaiThua(n) / (GiaiThua(k) * GiaiThua(n - k));
    }

    // 3. Tính Chỉnh hợp A(n, k)
    public static double ChinhHop(int n, int k)
    {
        if (k < 0 || k > n) return 0;
        return (double)GiaiThua(n) / GiaiThua(n - k);
    }
}

// Lớp kiểm thử (Program)
class Programm
{
    static void Main()
    {
        double x = 27;
        int n = 5, k = 2;

        Console.WriteLine($"Căn bậc 3 của {x} = {Units.CanBacBa(x)}");
        Console.WriteLine($"Tổ hợp C({n}, {k}) = {Units.ToHop(n, k)}");
        Console.WriteLine($"Chỉnh hợp A({n}, {k}) = {Units.ChinhHop(n, k)}");
    }
}