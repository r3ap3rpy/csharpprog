using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dstructors
{
    public class Destructable {
        //~Destructable() => Console.WriteLine("Destroying object!");
        ~Destructable()
        {
            Console.WriteLine("Destroying object!");
        }
        protected override void Finalize()
        {
            try
            {
                //statement for destroy
            }
            finally { 
                base.Finalize();
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
