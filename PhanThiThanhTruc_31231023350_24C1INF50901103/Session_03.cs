using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanThiThanhTruc_31231023350_24C1INF50901103
{
    internal class Session_03
    {
        static void Main(string[] args)
        {
            //Bai4_Ex01();
            //Bai4_Ex02();
            //Bai4_Ex03();
            //Bai4_Ex06();
            //Bai4_Ex07();
            Bai4_Ex04();
        }
        static void Bai4_Ex01() //1. Write a C# Sharp program to check whether a given number is even or odd.
        {
            Console.Write("Nhap vao so nguyen: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine($"So {a} la so chan");
            }
            else
            {
                Console.WriteLine($"So {a} la so le");
            }
        }
        public static void Bai4_Ex02() //2. Write a C# Sharp program to find the largest of three numbers.
        {
            Console.WriteLine("Vui long nhap vao ba so: ");
            Console.Write("Nhap vao so thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so thu hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so thu ba: ");
            int c = int.Parse(Console.ReadLine());
            int max = a;
            if (b > max)
            {
                if (c > max)
                {
                    max = c;
                }
                else
                {
                    max = b;
                }
            }
            Console.WriteLine($"So lon nhat trong ba so la {max}");
        }
        public static void Bai4_Ex03() //Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
        {
            Console.WriteLine("Vui long nhap toa do diem: ");
            Console.Write("Nhap toa do X: "); int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap toa do Y: "); int y = int.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Toa do da cho thuoc phan tu thu nhat");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Toa do da cho thuoc phan tu thu hai");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Toa do da cho thuoc phan tu thu ba");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Toa do da cho thuoc phan tu thu tu");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("Toa do da cho nam tai goc toa do");
            }
        }
        public static void Bai4_Ex04() // 1. Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
        {
            do
            {
                Console.WriteLine("Vui long nhap ba canh tam giac: ");
                Console.Write("Nhap canh a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Nhap canh b: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Nhap canh c: ");
                int c = int.Parse(Console.ReadLine());

            if (a + b > c && b + c > a && a + c > b)
            {
                if (a == b || b == c || c == a)
                {
                    if (a == b && b == c)
                    {
                        Console.WriteLine(" Tam giac do la tam giac deu");
                    }
                    else
                    {
                        Console.WriteLine("Tam giac do la tam giac can");
                    }
                }
                else
                {
                    Console.WriteLine("Tam giac do la tam giac khong can");
                }
            }
            else
            {
                    Console.WriteLine("Ba canh nay khong phai tam giac, vui long nhap lai.");
            }
                Console.WriteLine("Bạn có muốn tiếp tục nhập (y/n)?");
                string tiepTuc = Console.ReadLine();
                if (tiepTuc.ToLower() != "y")
                {
                    break;  // Thoát khỏi vòng lặp nếu người dùng không muốn tiếp tục
                }

            } while (true);
        }
        public static void Bai4_Ex05() //2. Write a program to read 10 numbers and find their average and sum.
        {
            double tong = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Nhap so thu {i + 1}: ");
                double number = Convert.ToDouble(Console.ReadLine());
                tong += number;
            }
            double tb = tong / 10;
            Console.WriteLine($"Tong cua 10 so: {tong}");
            Console.WriteLine($"Trung binh cua 10 so: {tb}");
        }
        public static void Bai4_Ex06() //3. Write a program to display the multiplication table of a given integer.
        {
            Console.WriteLine("Vui long nhap so nguyen cho truoc: ");
            int song = int.Parse(Console.ReadLine());
            Console.WriteLine($"BANG CUU CHUONG CUA {song}");
            int ketqua = 0;
            for (int i = 1; i < 11; i++)
            {
                ketqua = song * i;
                Console.WriteLine($"{song}*{i}={ketqua}");
            }
        }
        public static void Bai4_Ex07()//8. Write a program to determine whether a given number is prime or not.
        {
        }

    }
}
