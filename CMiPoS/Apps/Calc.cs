using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMiPoS.Apps
{
    internal class Calc
    {
        public void CalcAPP()
        {
            bool k = true;
            //Разкоментируйте строку ниже чтобы отключить программу
            //a = false;
            if (!k)
            {
                Console.WriteLine("This program blocked");
                return;
            }
            double a;
            double b;
            double total;
            char oper;
            Console.Write("Input a first number: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input a  number: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input a operator: ");
            oper = Convert.ToChar(Console.ReadLine());

            if (oper == '+')
            {
                total = a + b;
                Console.WriteLine(total);
            }

            else if (oper == '-')
            {
                total = a - b;
                Console.WriteLine(total);
            }

            else if (oper == '*')
            {
                total = a * b;
                Console.WriteLine(total);
            }

            else if (oper == '/')
            {
                total = a / b;
                Console.WriteLine(total);
            }
            else
            {
                Console.WriteLine("invalid operation.");
            }
        }
    }
}
