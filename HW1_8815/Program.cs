using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_8815
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number 1");
            string input = Console.ReadLine();//returns string
            int num1 = int.Parse(input);
            Console.WriteLine("Enter the number 2");
            input = Console.ReadLine();//reads line from keybooard and assigns to input variable
            int num2 = Convert.ToInt32(input);
            Console.WriteLine("Enter the operator:(+,-,/,*)");
            string op = Console.ReadLine();
            if (op == "+")
            {
                int tot = num1 + num2;
                Console.WriteLine("Total is " + tot + ".");
                Console.ReadLine();

            }
            if (op == "-")
            {
                int sub = num1 - num2;
                Console.WriteLine("Sub is" + sub + ".");
                Console.ReadLine();
            }
            if (op == "*")
            {
                int mul = num1 * num2;
                Console.WriteLine("Multiplication is" + mul + ".");
                Console.ReadLine();
            }
            if (op == "/")
            {
                double div = (num1 / num2);
                Console.WriteLine("Division is" + div + ".");
                Console.ReadLine();
            }

        }
    }
}

