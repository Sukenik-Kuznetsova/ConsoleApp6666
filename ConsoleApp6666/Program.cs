﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6666
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double x, f;
            Console.Write("Введите х= ");
            x = Convert.ToDouble(Console.ReadLine());
            f = 8 * Math.Sin(2 * x) - Math.Cos(2 * x);
            Console.WriteLine($"Для значения х = { x}, F = { f}.");
        }
    }
}
