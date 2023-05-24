using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CMiPoS.Apps
{
    internal class PLUS
    {
        public void plusAPP()
        {
            bool a = true;
            //Разкоментируйте строку ниже чтобы отключить программу
            //a = false;
            if (!a)
            {
                Console.WriteLine("This program blocked");
                return;
            }
            Console.WriteLine(" _________________\r\n| | ___________ |o|\r\n| | ___________ | |\r\n| | ___________ | |\r\n| | ___________ | |\r\n| |_____________| |\r\n|     _______     |\r\n|    |       |   ||\r\n| DD |       |   V|\r\n|____|_______|____|");
            Console.WriteLine("Insert the expansion disc...");
            Console.WriteLine("(Press any key to continue)");
            Console.ReadKey();
            Console.WriteLine("Reading a floppy disk...");
            Random rnd = new Random();
            int value = rnd.Next(1037, 1753);
            Thread.Sleep(value);
            Console.WriteLine("The floppy disk is not readable!!!");
        }
    }
}
