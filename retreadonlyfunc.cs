using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retreadonlyref
{   public readonly struct Pandemic
    {
        public string virusName { get; }
        public double infectRatio { get; }
        public int initialCases { get; }
        public double deathRate { get; }
        public Pandemic(string name, double ratio, int cases, double rate) { 
            virusName = name;
            infectRatio = ratio;
            initialCases = cases;
            deathRate = rate;
        }
    }
    public struct ClassRooms
    {
        public ClassRooms(string name, int size)
        {
            Name = name;
            Size = size;
            _currentUtilization = null;
        }
        private ClassRooms[] _currentUtilization;
        public string Name { get; set; }
        public int Size { get; set; }
        public override string ToString()
        {
            return $"{this.Name} :: {this.Size}";
        }
        public void SetRoom(ClassRooms[] classrooms) => _currentUtilization = classrooms;
        public ref readonly ClassRooms Getutilization(int x)
        {
            return ref _currentUtilization[x];
        }
    }
    internal class Program
    {
        static int[] a = new int[3] { 1, 2, 3 };
        static ref int GetIndex(int index)
        {
            return ref a[index];
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetIndex(0));
            var Rooms = new ClassRooms[] { new ClassRooms("Math", 10), new ClassRooms("Literature", 20) };
            var School = new ClassRooms();
            School.SetRoom(Rooms);
            Console.WriteLine(School.Getutilization(1));
            Console.WriteLine(School.Getutilization(0));
            Console.ReadKey();
        }
    }
}
