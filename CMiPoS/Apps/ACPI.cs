using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CMiPoS.Apps
{
    internal class ACPI
    {
        public void ShutDownAPP()
        {
            Console.Clear();
            Console.Write("The computer will shutdown in 3 seconds");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(500);
            Cosmos.Core.ACPI.Shutdown();
        }
        public void RebootAPP()
        {
            Console.Clear();
            Console.Write("The computer will restart in 3 seconds");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(500);
            Cosmos.Core.ACPI.Reboot();
        }
    }
}
