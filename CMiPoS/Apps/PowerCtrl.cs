using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMiPoS.Apps
{
    internal class PowerCtrl
    {
        public void PowerCtrlAPP()
        {
            bool a = true;
            //Разкоментируйте строку ниже чтобы отключить программу
            //a = false;
            if (!a)
            {
                Console.WriteLine("This program blocked");
                return;
            }
            Console.Clear();
            Console.WriteLine("+----------------------+");
            Console.WriteLine("| What to do?          |");
            Console.WriteLine("+----------------------+");
            Console.WriteLine("| Shutdown             |");
            Console.WriteLine("| Reboot               |");
            Console.WriteLine("| Exit                 |");
            Console.WriteLine("+----------------------+");
            var power = Console.ReadLine();
            switch (power)
            {
                case "Shutdown":
                    var ACPIShutdown = new ACPI();
                    ACPIShutdown.ShutDownAPP();
                    break;
                case "Reboot":
                    var ACPIReboot = new ACPI();
                    ACPIReboot.ShutDownAPP();
                    break;
                case "Exit":
                    bool k = true;
                    if (!k)
                    {
                        return;
                    }
                    else
                    {
                        return;
                    }
            }
        }
    }
}
