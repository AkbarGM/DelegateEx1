using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    class Program
    {
        delegate int Operation(int a, int b);
        static void Main(string[] args)
        {
            Operation operation;
            operation = Add;
            Console.WriteLine(operation(3, 4));
            operation = Multiply;
            Console.WriteLine(operation(3, 4));

            Console.ReadLine();

        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
