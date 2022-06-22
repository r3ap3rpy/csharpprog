using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decraisehandleevents
{
    internal class Program
    {
        public delegate void MissingConsumableHandler(string name);
        public event MissingConsumableHandler OutOfMilk;
        public void HandleOutOfMilk(string name) {
            Console.WriteLine($"Add {name} to the shopping list!");
            Console.WriteLine($"Notifying Mom about the disaster!");
        }
        static void Main(string[] args)
        {
            Freezer.HandleOutOfMilk += MissingConsumableHandler(HandleOutOfMilk);
            HandleOutOfMilk("3 bottles of milk!");


        }
    }
}
