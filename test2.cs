
using System;

class Phong
{
    public string LoaiPhong;
    public int SoNgayThue;
    public double TienDichVu;

    public Phong(string loaiPhong, int soNgayThue, double tienDichVu)
    {
        LoaiPhong = loaiPhong.ToUpper();
        SoNgayThue = soNgayThue;
        TienDichVu = tienDichVu;
    }

    public double TinhTien()
    {
        double donGia = 0;
        double tongTien;

        switch (LoaiPhong)
        {
            case "A":
                donGia = 80;
                break;
            case "B":
                donGia = 60;
                break;
            case "C":
                donGia = 40;
                break;
            default:
                Console.WriteLine("Loai phong khong hop le!");
                return 0;
        }

        tongTien = donGia * SoNgayThue;

        // Cong tien dich vu neu la phong loai A
        if (LoaiPhong == "A")
        {
            tongTien += TienDichVu;
        }

        // Giam gia 10% cho phong A va B neu o tu 5 ngay tro len
        if ((LoaiPhong == "A" || LoaiPhong == "B") && SoNgayThue >= 5)
        {
            tongTien *= 0.9;
        }

        return tongTien;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Nhap loai phong (A, B, C): ");
        string loaiPhong = Console.ReadLine();

        Console.Write("Nhap so ngay thue: ");
        int soNgayThue = int.Parse(Console.ReadLine());

        double tienDichVu = 0;

        if (loaiPhong.ToUpper() == "A")
        {
            Console.Write("Nhap tien dich vu (USD): ");
            tienDichVu = double.Parse(Console.ReadLine());
        }

        Phong p = new Phong(loaiPhong, soNgayThue, tienDichVu);

        Console.WriteLine($"So tien khach phai tra: {p.TinhTien():F2} USD");
    }
}
