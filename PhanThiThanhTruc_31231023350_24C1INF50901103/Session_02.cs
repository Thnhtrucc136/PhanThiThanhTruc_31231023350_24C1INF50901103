﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanThiThanhTruc_31231023350_24C1INF50901103
{
    internal class Session_02
    {
        //static void Main(string[] args)
        //{
        //    //Excercises unit 3 Data types
        //    //Bai3_Ex01();
        //    //Bai3_Ex02();
        //    //Bai3_Ex03();
        //    //Excercises unit 4 Operators and control flow
        //    //Bai4_Ex01();
        //    //Bai4_Ex02();
        //    //Bai4_Ex03();
        //    //Bai4_Ex04();
        //    Bai4_Ex05();
        //}
        public static void Bai3_Ex01()
        {
            Console.Write("Please enter Celsius degrees: ");
            int Cel = int.Parse(Console.ReadLine());
            int Kel = Cel + 273;
            int Fah = Cel * 18 / 10 + 32;
            Console.WriteLine($"Celsius to Kalvin: {Kel}");
            Console.WriteLine($"Celsius to Fahrenheit: {Fah}");
        }
        public static void Bai3_Ex02()
        {
            Console.Write("Please enter radius: ");
            double r = float.Parse(Console.ReadLine());
            double surface = 4 * Math.PI * Math.Pow(r, 2);
            double volume = 4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"Surface: {surface}");
            Console.WriteLine($"Volume: {volume}");
        }
        public static void Bai3_Ex03()
        {
            Console.Write("Nhap vao so dau tien: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so thu hai: ");
            int b = int.Parse(Console.ReadLine());
            int cong = a + b;
            int tru = a - b;
            int nhan = a * b;
            int chiang = a / b;
            double chiadu = a % b;
            Console.WriteLine("Ket qua phep tinh: ");
            Console.WriteLine($"{a} + {b} = {cong}");
            Console.WriteLine($"{a} - {b} = {tru}");
            Console.WriteLine($"{a} * {b} = {nhan}");
            Console.WriteLine($"{a} / {b} = {chiang}");
            Console.WriteLine($"{a} mod {b} = {chiadu}");
        }
        public static void Bai4_Ex01()
        {
            Console.Write("Nhap vao so dau tien: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so thu hai: ");
            int b = int.Parse(Console.ReadLine());
            int cong = a + b;
            int tru = a - b;
            int nhan = a * b;
            int chia = a / b;
            Console.WriteLine("Ket qua phep tinh hai so: ");
            Console.WriteLine($"{a} + {b} = {cong}");
            Console.WriteLine($"{a} - {b} = {tru}");
            Console.WriteLine($"{a} * {b} = {nhan}");
            Console.WriteLine($"{a} / {b} = {chia}");
        }
        public static void Bai4_Ex02()
        {
            Console.Write("Nhap gia tri y: ");
            int y = int.Parse(Console.ReadLine());
            if (y <= 5 && y >= -5)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine($"Voi y = {y}, thi x = {x}");
            }
            else
            {
                Console.WriteLine("Vui long nhap lai gia tri y");
            }
        }
        public static void Bai4_Ex03()
        {
            Console.Write("Nhap vao khoang cach (km): ");
            double kc = double.Parse(Console.ReadLine());//km
            Console.WriteLine("Nhap vao thoi gian: ");
            Console.Write("Nhap so gio: ");
            float gio = float.Parse(Console.ReadLine());
            Console.Write("Nhap so phut: ");
            float phut = float.Parse(Console.ReadLine());
            Console.Write("Nhap so giay: ");
            float giay = float.Parse(Console.ReadLine());
            double time = gio + (phut / 60.0) + (giay / 3600.0);
            double Tocdo = kc / time;
            Console.WriteLine($"Toc do theo km/h: {Tocdo} km/h");
            Console.WriteLine($"Toc do theo miles/h: {Tocdo * 0.621371} miles/h");
        }
        public static void Bai4_Ex04()
        {
            Console.Write("Nhap ban kinh hinh cau: ");
            double r = float.Parse(Console.ReadLine());
            double Dt = 4 * Math.PI * Math.Pow(r, 2);
            double Tt = 4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"Dien tich be mat cua hinh cau ban kinh {r}: {Dt}");
            Console.WriteLine($"The tich hinh cau ban kinh {r}: {Tt}");
        }
        public static void Bai4_Ex05()
        {
            double number;
            string nguyenam = "aoeuiAoeui";
            Console.Write("Vui long nhap vao mot ky tu:");
            string input = Console.ReadLine();
            if (input.Length != 1)
            {
                Console.WriteLine("Vui long nhap mot ky tu duy nhat.");
                return;
            }
            char kyTu = input[0];
            if (double.TryParse(kyTu.ToString(), out number))
            {
                Console.WriteLine($"Ky tu '{kyTu}' la chu so.");
            }
            else if (IsVowel(kyTu))
            {
                Console.WriteLine($"Ky tu '{kyTu}' la nguyen am.");
            }
            else
            {
                Console.WriteLine($"Ky tu '{kyTu}' là ky hieu khac.");
            }
            static bool IsVowel(char kyTu)
            {
                kyTu = char.ToLower(kyTu); // Chuyển ký tự thành chữ thường
                return kyTu == 'a' || kyTu == 'e' || kyTu == 'i' || kyTu == 'o' || kyTu == 'u';
            }
        }
    }
}
