using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using System.Threading;
using Cosmos.System.Network;
using Cosmos.System.Network.Config;
using Cosmos.System.Network.IPv4.UDP.DHCP;

namespace CMiPoS.Apps
{
    internal class ResMon
    {
        public void ResMonAPP()
        {
            bool a = true;
            //Разкоментируйте строку ниже чтобы отключить программу
            //a = false;
            if (!a)
            {
                Console.WriteLine("This program blocked");
                return;
            }

            string Cpu = Cosmos.Core.CPU.GetCPUBrandString();
            uint AmountRam = Cosmos.Core.CPU.GetAmountOfRAM();
            ulong AviableRam = Cosmos.Core.GCImplementation.GetAvailableRAM();
            ulong UsedRam = AmountRam - AviableRam;
            Console.WriteLine("Resource Monitor");
            Console.WriteLine("CPU: " + Cpu);
            Console.WriteLine("Amount RAM: " + AmountRam + " KB");
            Console.WriteLine("Available RAM: " + AviableRam + " KB");
            Console.WriteLine("Used RAM: " + UsedRam + " KB");
        }

    }
}
