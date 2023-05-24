using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using System.Threading;
using Cosmos.System.Network;
using Cosmos.System.Network.Config;
using Cosmos.System.Network.IPv4.UDP.DHCP;
using CMiPoS.Apps;
using System.Timers;

namespace CMiPoS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
			using (var xClient = new DHCPClient())
            {
                xClient.SendDiscoverPacket();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                LoginSys();
            }
        }
        public void LoginSys()
        {
            string username = "Cactus"; // здесь будут храниться имя пользователя и пароль
            string password = "Cactus";

            Console.WriteLine("Login: ");
            string inputUsername = Console.ReadLine(); // получаем введенное пользователем имя

            Console.WriteLine("Password: ");
            string inputPassword = Console.ReadLine(); // получаем введенный пользователем пароль

            if (inputUsername == username && inputPassword == password) // проверяем, соответствуют ли введенные данные имени пользователя и паролю
            {
                Welcome();
            }
            else
            {
                Console.WriteLine("WRONG USER NAME OR PASSWORD!"); // если не соответствуют, выводим сообщение об ошибке
            }
        }
        public void Welcome()
        {
            Console.WriteLine("Version Alpha 2.5 ByteForge (SP) Single Programmer");
            Console.WriteLine("The ByteForge 2023");
            Run();
        }
        protected override void Run()
        {
            Console.Write("Command >>");
            var input = Console.ReadLine();
            switch (input) //'Метод' для запуска APP программ.
            {
                default: //Основная комманда, если будет введено то что не является коммандой.
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("ERROR: Unknown command!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case "about":
                    Console.WriteLine("CMiP OS Version Alpha 2.5");
                    break;
                case "help":
                    var Help = new Help();
                    Help.HelpAPP();
                    break;
                case "plus":
                    var plus = new PLUS();
                    plus.plusAPP();
                    break;
                case "clear":
                    Console.Clear();
                    break;
                case "calc":
                    var calc = new Calc();
                    calc.CalcAPP();
                    break;
                case "resmon":
                    var resmon = new ResMon();
                    resmon.ResMonAPP();
                    break;
                case "power":
                    var powercntr = new PowerCtrl();
                    powercntr.PowerCtrlAPP();
                    break;
            }
        }
    }
}
