using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMiPoS.Apps
{
    internal class Help
    {
        public void HelpAPP()
        {
            bool a = true;
            //Разкоментируйте строку ниже чтобы отключить программу
            //a = false;
            if (!a)
            {
                Console.WriteLine("This program blocked");
                return;
            }
            Console.WriteLine("RESMON     Resource Monitor");
            Console.WriteLine("ABOUT      About of PC");
            Console.WriteLine("CLEAR      Clear Screen");
            Console.WriteLine("PLUS       Improvement Disk (Need a floppy disk)");
            Console.WriteLine("CALC       Calculator");
            Console.WriteLine("BEEP       Beep in PC Speaker");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
