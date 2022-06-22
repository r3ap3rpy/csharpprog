using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllowedIntMembers
{
    public interface ServerInterface { 
        string name { get; set; }
        string status { get; set; }
        void restart();
        void stop();
        void start();
        void getStatus();
        event EventHandler statusChanged;
    }
    public class MyEventArgs : EventArgs { }
    public class Server : ServerInterface
    {
        public string name { get; set; }
        public string status { get; set; }
        public event EventHandler statusChanged;
        public Server(string Name) { name = Name; status = "off"; }
        public void getStatus()
        {
            Console.WriteLine($"The server: {this.name} is in status: {this.status}");
        }
        public void start()
        {
            if (this.status == "off")
            {
                Console.WriteLine($"Starting server: {this.name}");
                this.status = "on";
            }
            else if (this.status == "on")
            {
                Console.WriteLine($"The server: {this.name} is already on!");
            }
            else {
                Console.WriteLine($"The server: {this.name} is in unknown state!");    
            }
        }
        public void stop()
        {
            if (this.status == "off")
            {
                Console.WriteLine($"The server: {this.name} is already off!");                
            }
            else if (this.status == "on")
            {
                Console.WriteLine($"The server: {this.name} is stopping");
                this.status = "on";
            }
            else
            {
                Console.WriteLine($"The server: {this.name} is in unknown state!");
            }
        }
        public void restart()
        {
            Console.WriteLine($"Restarting server: {this.name}");
        }
        protected virtual void restart(MyEventArgs e) {
            statusChanged?.Invoke(this, e);
        }
    }
    public class Interfacing
    {
        static void Main(string[] args)
        {
            Server a = new Server("Linux machine!");
            a.start();
            a.stop();
            a.restart();
            Console.Read();
        }
    }
}
