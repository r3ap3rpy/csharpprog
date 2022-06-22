using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstructor
{
    public class ProgrammingLanguage
    {
        private string name;
        private double version;
        public ProgrammingLanguage(string LanguageName, double LanguageVersion)
        {
            name = LanguageName;
            version = LanguageVersion;
        }
    }
    public class Language
    {
        private string LanguageName;
        private string Type;
        //public Language(string name, string type) => Name = name; Type = type;
        public string Name {
            get => LanguageName;
            set => LanguageName = value;
        }
        public string Type {
            get => Type;
            set => Type = value;    
        }
    }
    public class Python : Language {
        private static double minimumVersion;
        public Python(string creator, string languageType) : base(creator, languageType) 
        { }
        static Python() => minimumVersion = 18;
    }
    public class VillageCoordinates
    {
        public double lat, lng;
        public VillageCoordinates()
        {
            lat = 0;
            lng = 0;
        }
        public VillageCoordinates(double lat, double lng) {
            this.lat = lat;
            this.lng = lng;
        }
    }
    public class Vehicle
    {
        private Vehicle() { }
        public static int wheels = 4;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
