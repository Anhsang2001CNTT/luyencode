using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
    namespace tinh
{
    class Program
    {
        static void Main(String[] args)
        {
            double a, b, S, V;
            Console.Write("nhap vao chieu dai a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("nhop vao chieu rong b:");
            b = Convert.ToDouble(Console.ReadLine());
            S = a * b;
            V = (a + b) * 2;
            Console.Write($"Dien tich hinh chu nhat:{S} ");
            Console.Write($"Chu vi hinh chu nhat:{V}");
        }
    }
}


