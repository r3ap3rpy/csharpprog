using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scopenvisibility
{
    public class A {
        int a = 6;
        void first() {
            double c = 10.0;
            Console.WriteLine(c);
        }
    }
    public class Visibility {
        public string message = "I am visible from anywhere!";
        protected string pmessage = "Only from the same class!";
        internal string imessage = "Only from within the same project!";
        private string privmessage = "Untouchable!";
        public void ProtectedMessage() {
            Console.WriteLine(pmessage);
            Console.WriteLine(privmessage);
        }
    }
    public class iVisibility : Visibility {
        public static void Main() {
            iVisibility a = new iVisibility();
            Visibility b = new Visibility();
            Console.WriteLine(a.message);
            Console.WriteLine(a.imessage);
            Console.WriteLine(a.pmessage);
            b.ProtectedMessage();
            Console.ReadKey();

        }
    }
    
}
