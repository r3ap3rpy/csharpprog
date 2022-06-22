using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumManipulation
{
    public class BeforeEnum {
        public int None = 0;
        public int Development = 1;
        public int Testing = 2;
        public int Production = 3;
    }
    public class Server {
        public string Name;
        public int Tier;
        public Server(int tier, string name) {
            this.Name = name;
            this.Tier = tier;
        }
    }
    public enum Tiers { 
        None,
        Development,
        Testing,
        Production,
    }
     [Flags]public enum BitTiers
    {
        None = 1,
        Development = 2,
        Testing = 4,
        Production = 8,
        AlmostProd = Production | None,
        AlmostTest = Testing | None,
        AlmostDevelopment = Development | None,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var level in Enum.GetValues(typeof(Tiers))){
                Console.WriteLine($"Tier: {level} has value of {(int)level}");
            }
            foreach (var level in Enum.GetValues(typeof(BitTiers)))
            {
                Console.WriteLine($"Tier: {level} has value of {(int)level}");
            }
            Console.ReadKey();
        }
    }
}
