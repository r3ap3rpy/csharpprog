using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoImplProps
{
    public class NetworkDevice
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Serial { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            NetworkDevice Switch= new NetworkDevice();
                Switch.Name = "L2 Switch";
                Switch.Location = "Amserdam";
                Switch.Serial = "123345";
                Console.WriteLine($"The device name: {Switch.Name}, location: {Switch.Location}, serial: {Switch.Serial}");
                Console.Read();
        }
    }
}
