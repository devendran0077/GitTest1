﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Some changes happened 123 123 123 1234
            Console.WriteLine("Hello World!");
            Console.WriteLine(Add(3, 4));
 Console.WriteLine(Add(30, 40));
            Console.WriteLine(Multiply(3, 4));
            

            Console.ReadLine();
        }
        private static  int  Add(int a,int b)
        {
            return a + b;
        }
        
        private static int Multiply(int a, int b)
        {
            return a + b;
        }
        
    }
}
