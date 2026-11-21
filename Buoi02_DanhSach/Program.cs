using System;
using System.Collections.Generic;

namespace Buoi02_Stack_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== Bài 1: Kiểm tra tính đúng đắn của biểu thức toán học ===");
            Bai1();

            Console.WriteLine("\n=== Bài 2: Mô phỏng lịch sử trình duyệt web ===");
            Bai2();

            Console.WriteLine("\n=== Bài 3: Mô phỏng quá trình thực thi chương trình ===");
            Bai3();

            Console.WriteLine("\n=== Bài 4: Mô phỏng hệ thống in ấn ===");
            Bai4();

            Console.WriteLine("\n=== Bài 5: Mô phỏng đường truyền dữ liệu ===");
            Bai5();

            Console.ReadKey();
        }

        static void Bai1()
        {
            Console.Write("Nhập biểu thức: ");
            string expr = Console.ReadLine() ?? "";
            Stack<char> st = new Stack<char>();
            bool hopLe = true;

            foreach (char c in expr)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    st.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (st.Count == 0)
                    {
                        hopLe = false;
                        break;
                    }
                    char top = st.Pop();
                    if ((c == ')' && top != '(') ||
                        (c == ']' && top != '[') ||
                        (c == '}' && top != '{'))
                    {
                        hopLe = false;
                        break;
                    }
                }
            }

            if (st.Count != 0)
            {
                hopLe = false;
            }

            if (hopLe)
            {
                Console.WriteLine("Biểu thức hợp lệ.");
            }
            else
            {
                Console.WriteLine("Biểu thức sai.");
            }
        }

        static void Bai2()
        {
            Stack<string> backStack = new Stack<string>();
            Stack<string> forwardStack = new Stack<string>();
            string current = "Home";

            while (true)
            {
                Console.WriteLine("Trang hiện tại: " + current);
                Console.WriteLine("1. Truy cập trang mới | 2. Back | 3. Forward | 0. Thoát");
                Console.Write("Chọn: ");
                string choice = Console.ReadLine() ?? "";

                if (choice == "1")
                {
                    Console.Write("Nhập URL trang mới: ");
                    string url = Console.ReadLine() ?? "";
                    backStack.Push(current);
                    current = url;
                    forwardStack.Clear();
                }
                else if (choice == "2")
                {
                    if (backStack.Count > 0)
                    {
                        forwardStack.Push(current);
                        current = backStack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("Không thể quay lại (Back rỗng).");
                    }
                }
                else if (choice == "3")
                {
                    if (forwardStack.Count > 0)
                    {
                        backStack.Push(current);
                        current = forwardStack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("Không thể chuyển tiếp (Forward rỗng).");
                    }
                }
                else if (choice == "0")
                {
                    break;
                }
            }
        }

        static void Bai3()
        {
            Stack<string> callStack = new Stack<string>();

            callStack.Push("Main() [return: exit]");
            Console.WriteLine("Gọi: " + callStack.Peek());

            callStack.Push("TinhTong(a=3, b=5) [return: Main]");
            Console.WriteLine("Gọi: " + callStack.Peek());

            callStack.Push("CongHaiSo(x=3, y=5) [return: TinhTong]");
            Console.WriteLine("Gọi: " + callStack.Peek());

            while (callStack.Count > 0)
            {
                string frame = callStack.Pop();
                Console.WriteLine("Kết thúc và trả về từ: " + frame);
            }
        }

        static void Bai4()
        {
            Queue<string> printQueue = new Queue<string>();

            printQueue.Enqueue("TaiLieu_1.pdf");
            printQueue.Enqueue("BaoCao_2.docx");
            printQueue.Enqueue("Slide_3.pptx");

            while (printQueue.Count > 0)
            {
                string job = printQueue.Dequeue();
                Console.WriteLine("Đang xử lý in: " + job);
            }
        }

        static void Bai5()
        {
            Queue<string> dataQueue = new Queue<string>();

            dataQueue.Enqueue("Packet_1: Hello");
            dataQueue.Enqueue("Packet_2: Data");
            dataQueue.Enqueue("Packet_3: End");

            while (dataQueue.Count > 0)
            {
                string packet = dataQueue.Dequeue();
                Console.WriteLine("Nhận và xử lý: " + packet);
            }
        }
    }
}