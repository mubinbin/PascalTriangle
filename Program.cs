using System;
using System.Collections.Generic;
namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Ptrianle = PascalTriangle.Layer(8);
            foreach(int i in Ptrianle)
            {
                Console.WriteLine(i);
            }
        }
    }
}




