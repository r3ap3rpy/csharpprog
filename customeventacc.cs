using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEventAccessors
{
    public class Machine
    {
        private int _utilization = 0;
        private int _safeutil = 70;
        public delegate void StressLimitExceededEventHandler(object source, EventArgs e);
        public event StressLimitExceededEventHandler StressLimitExceeded;
        public virtual void OnStressLevelExceeded(EventArgs e) 
            { StressLimitExceeded?.Invoke(this, e); }
        public int Performance
        {
            get { return _utilization; }
        }
        static void MachineStressLimitExceeded(object source, EventArgs e) {
            Machine mechabot = (Machine)source;
            Console.WriteLine($"Stress level warning: {mechabot.Performance}%");
        }
        public void StressTest(int utilization) {
            int oldUtilization = _utilization;
            _utilization += utilization;
            if (oldUtilization <= _safeutil && _utilization > _safeutil) {
                OnStressLevelExceeded(new EventArgs());
            }
        }
        static void Main(string[] args)
        {
            Machine machine = new Machine();
            machine.StressLimitExceeded += new StressLimitExceededEventHandler(MachineStressLimitExceeded);
            Console.WriteLine($"The util is {machine.Performance} %");
            machine.StressTest(60);
            Console.WriteLine($"The util is {machine.Performance} %");
            machine.StressTest(15);
            Console.WriteLine($"The util is {machine.Performance} %");
            machine.StressTest(75);
            Console.WriteLine($"The util is {machine.Performance} %");
            Console.ReadKey();

        }
    }
}
