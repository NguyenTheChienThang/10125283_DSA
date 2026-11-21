using System;
using System.Collections.Generic;

namespace Buoi02_DanhSach
{
    struct NhanVien
    {
        public string MaNV;
        public string HoTen;
        public int NamSinh;
        public string PhongBan;
        public long LuongCoBan;
        public long Thuong;
        public long ThucLinh => LuongCoBan + Thuong;
    }

    class Node
    {
        public int Data;
        public Node Next;
        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== Bài 1: Mảng n số nguyên dương ===");
            Bai1();

            Console.WriteLine("\n=== Bài 2: Danh sách nhân viên ===");
            Bai2();

            Console.WriteLine("\n=== Bài 3: Ma trận vuông n x n ===");
            Bai3();

            Console.WriteLine("\n=== Bài 4: Danh sách liên kết đơn (số nguyên dương) ===");
            Bai4();

            Console.WriteLine("\n=== Bài 5: Danh sách liên kết đơn l (số nguyên) ===");
            Bai5();

            Console.ReadKey();
        }

        static void Bai1()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "] = ");
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Danh sách: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Nhập phần tử cần chèn x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhập vị trí cần chèn k (0..n): ");
            int k = int.Parse(Console.ReadLine());

            if (k >= 0 && k <= n)
            {
                int[] b = new int[n + 1];
                for (int i = 0; i < k; i++)
                {
                    b[i] = a[i];
                }
                b[k] = x;
                for (int i = k; i < n; i++)
                {
                    b[i + 1] = a[i];
                }
                a = b;
                n++;

                Console.Write("Danh sách sau khi chèn: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(a[i] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Bai2()
        {
            List<NhanVien> ds = new List<NhanVien>
            {
                new NhanVien { MaNV = "NV01", HoTen = "Nguyễn Văn An", NamSinh = 1998, PhongBan = "IT", LuongCoBan = 12000000, Thuong = 1500000 },
                new NhanVien { MaNV = "NV03", HoTen = "Trần Thị Bình", NamSinh = 1999, PhongBan = "IT", LuongCoBan = 10000000, Thuong = 1000000 },
                new NhanVien { MaNV = "NV02", HoTen = "Lê Minh Cường", NamSinh = 1997, PhongBan = "HR", LuongCoBan = 10000000, Thuong = 2000000 },
                new NhanVien { MaNV = "NV04", HoTen = "Phạm Thu Dung", NamSinh = 2000, PhongBan = "Sales", LuongCoBan = 14000000, Thuong = 800000 }
            };

            long tongThucLinh = 0;
            foreach (NhanVien nv in ds)
            {
                tongThucLinh += nv.ThucLinh;
            }
            Console.WriteLine("a. Tổng thực lĩnh tháng của tất cả nhân viên: " + tongThucLinh);

            long minLuong = ds[0].LuongCoBan;
            foreach (NhanVien nv in ds)
            {
                if (nv.LuongCoBan < minLuong) minLuong = nv.LuongCoBan;
            }
            Console.WriteLine("b. Nhân viên có mức lương cơ bản thấp nhất:");
            foreach (NhanVien nv in ds)
            {
                if (nv.LuongCoBan == minLuong)
                {
                    Console.WriteLine(nv.MaNV + " - " + nv.HoTen + " - Lương CB: " + nv.LuongCoBan + " - Thực lĩnh: " + nv.ThucLinh);
                }
            }

            int demThuongCao = 0;
            foreach (NhanVien nv in ds)
            {
                if (nv.Thuong >= 1200000) demThuongCao++;
            }
            Console.WriteLine("c. Số lượng nhân viên có mức thưởng >= 1200000: " + demThuongCao);

            List<NhanVien> sapXep = new List<NhanVien>(ds);
            sapXep.Sort(delegate (NhanVien x, NhanVien y)
            {
                int cmpPB = string.Compare(x.PhongBan, y.PhongBan, StringComparison.Ordinal);
                if (cmpPB != 0) return cmpPB;
                return string.Compare(y.MaNV, x.MaNV, StringComparison.Ordinal);
            });
            Console.WriteLine("d. Danh sách tăng dần theo phòng ban, trùng phòng ban thì giảm dần theo mã NV:");
            foreach (NhanVien nv in sapXep)
            {
                Console.WriteLine(nv.PhongBan + " | " + nv.MaNV + " | " + nv.HoTen + " | Thực lĩnh: " + nv.ThucLinh);
            }

            Console.WriteLine("e. Cập nhật tăng lương cơ bản tất cả nhân viên lên 5%:");
            for (int i = 0; i < ds.Count; i++)
            {
                NhanVien nv = ds[i];
                nv.LuongCoBan = (long)Math.Round(nv.LuongCoBan * 1.05);
                ds[i] = nv;
                Console.WriteLine(ds[i].MaNV + " - " + ds[i].HoTen + " - Lương CB mới: " + ds[i].LuongCoBan + " - Thực lĩnh mới: " + ds[i].ThucLinh);
            }
        }

        static void Bai3()
        {
            Console.Write("Nhập n (0 <= n < 100): ");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("a[" + i + "," + j + "] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int tong = 0;
            int minDuong = int.MaxValue;
            int tongCheoPhu = 0;
            bool tangDanCheoChinh = true;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tong += a[i, j];
                    if (a[i, j] > 0 && a[i, j] < minDuong)
                    {
                        minDuong = a[i, j];
                    }
                    if (i + j == n - 1)
                    {
                        tongCheoPhu += a[i, j];
                    }
                }
                if (i > 0 && a[i, i] <= a[i - 1, i - 1])
                {
                    tangDanCheoChinh = false;
                }
            }

            Console.WriteLine("a. Tổng tất cả các phần tử của ma trận: " + tong);
            if (minDuong == int.MaxValue)
                Console.WriteLine("b. Ma trận không có giá trị dương.");
            else
                Console.WriteLine("b. Giá trị dương nhỏ nhất của ma trận: " + minDuong);
            Console.WriteLine("c. Tổng các phần tử nằm trên đường chéo phụ: " + tongCheoPhu);
            Console.WriteLine("d. Đường chéo chính tăng dần: " + tangDanCheoChinh);
        }

        static void ThemCuoi(ref Node head, int val)
        {
            Node moi = new Node(val);
            if (head == null)
            {
                head = moi;
                return;
            }
            Node p = head;
            while (p.Next != null) p = p.Next;
            p.Next = moi;
        }

        static void XoaDauTien(ref Node head, int val)
        {
            if (head == null) return;
            if (head.Data == val)
            {
                head = head.Next;
                return;
            }
            Node t = head;
            Node p = head.Next;
            while (p != null)
            {
                if (p.Data == val)
                {
                    t.Next = p.Next;
                    return;
                }
                t = p;
                p = p.Next;
            }
        }

        static void InDSLK(Node head)
        {
            Node p = head;
            while (p != null)
            {
                Console.Write(p.Data + " ");
                p = p.Next;
            }
            Console.WriteLine();
        }

        static void Bai4()
        {
            Node pHead = null;
            int[] values = { 12, 5, 8, 5, 20, 3 };
            foreach (int v in values)
            {
                ThemCuoi(ref pHead, v);
            }

            Console.Write("Danh sách liên kết đơn ban đầu: ");
            InDSLK(pHead);

            Console.Write("Nhập x cần đếm và xóa: ");
            int x = int.Parse(Console.ReadLine());

            int demX = 0;
            int minDuong = int.MaxValue;
            Node cur = pHead;
            while (cur != null)
            {
                if (cur.Data == x) demX++;
                if (cur.Data > 0 && cur.Data < minDuong) minDuong = cur.Data;
                cur = cur.Next;
            }

            Console.WriteLine("a. Số lượng phần tử bằng " + x + ": " + demX);
            Console.WriteLine("b. Phần tử dương nhỏ nhất: " + (minDuong == int.MaxValue ? "Không có" : minDuong.ToString()));

            XoaDauTien(ref pHead, x);
            Console.Write("c. Danh sách sau khi xóa " + x + " xuất hiện đầu tiên: ");
            InDSLK(pHead);
        }

        static bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static void Bai5()
        {
            Node l = null;
            int[] nums = { -4, 0, 7, 2, -9, 11, 0, 5 };
            foreach (int v in nums)
            {
                ThemCuoi(ref l, v);
            }

            Console.Write("Danh sách l: ");
            InDSLK(l);

            Console.Write("Nhập x cần đếm: ");
            int x = int.Parse(Console.ReadLine());

            int maxVal = int.MinValue;
            long tong = 0;
            int demNT = 0;
            int demAm = 0;
            int demKhong = 0;
            int demDuong = 0;
            int demX = 0;
            int minDuong = int.MaxValue;

            Node p = l;
            while (p != null)
            {
                int val = p.Data;
                if (val > maxVal) maxVal = val;
                tong += val;
                if (LaSoNguyenTo(val)) demNT++;
                if (val < 0) demAm++;
                else if (val == 0) demKhong++;
                else
                {
                    demDuong++;
                    if (val < minDuong) minDuong = val;
                }
                if (val == x) demX++;
                p = p.Next;
            }

            Console.WriteLine("a. Phần tử lớn nhất: " + (l == null ? "Rỗng" : maxVal.ToString()));
            Console.WriteLine("b. Tổng các phần tử: " + tong);
            Console.WriteLine("c. Số lượng số nguyên tố: " + demNT);
            Console.WriteLine("d. Số âm: " + demAm + " | Số bằng 0: " + demKhong + " | Số dương: " + demDuong);
            Console.WriteLine("e. Số lượng phần tử bằng " + x + ": " + demX);
            Console.WriteLine("f. Phần tử dương nhỏ nhất: " + (minDuong == int.MaxValue ? "Không có" : minDuong.ToString()));
        }
    }
}