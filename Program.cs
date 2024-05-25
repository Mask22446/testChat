using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void WriteSome() { Console.WriteLine(666); }
        static void Main(string[] args)
        {
            int x, y, z;
            x = y = z =100;
            Car colorOfCar = new Car();
            Console.WriteLine(x + y + z);
            WriteSome();
            Console.WriteLine(colorOfCar.color);
            Console.ReadLine();
        }
    }
}
