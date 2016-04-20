using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Getip
{
    class Program
    {
        static void Main()
        {
            var card = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault();
            //Console.WriteLine(NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault().Name.ToString());

            string address = card.GetIPProperties().GatewayAddresses.FirstOrDefault().Address.ToString();
            
            Console.WriteLine(address );
            Console.ReadLine();
        }

    }
}
