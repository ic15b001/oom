using Newtonsoft.Json;
using System.IO;
using System;


namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var ifahrzeuge = new IFahrzeuge[]
            {
                new Mech("Urbanmech", "Leicht" , 30, 30000),
                new Mech("Assassin", "Mittel", 40 , 40000),
                new Tank("Swift Wind Scout Car", "Wheeled", 7 ,7000 ),
                new Tank("Packrat", "Wheeled", 20, 20000),
            };

            Console.WriteLine("----- IFahrzeuge ANFANG -----\n");

            foreach (var m in ifahrzeuge)
            {
                Console.WriteLine("{0,-42} {1,4} t {2,6} cB ", m.Bezeichnung, m.Tonne, m.Preis);
            }

            Console.WriteLine("\n----- IFahrzeuge ENDE -----\n----- Mech ANFANG -----\n");

            var mech = new[]
            {
                new Mech("Panther", "Leicht",35, 35000),
                new Mech("Steppenwolf", "Mittel",45,45000),
                new Mech("Marauder", "Schwer",75,75000),
                new Mech("Atlas", "Überschwer",100,100000),
            };
            foreach (var m in mech)
            {
                Console.WriteLine("{0,-20} {1,-20}  {2,4} t {3,6} cB ", m.Bezeichnung, m.Klasse, m.Tonne, m.Preis);
            }

            Console.WriteLine("\n----- Neue Preise Mech-----\n");

            foreach (var m in mech)
            {
                Console.WriteLine("{0,-20} {1,-20}  {2,4} t {3,6} cB ", m.Bezeichnung, m.Klasse, m.Tonne, m.Preisupdate());
            }

            Console.WriteLine("\n----- Mech ENDE -----\n----- Tank ANFANG -----\n");

            var tank = new[]
            {
                new Tank("Swift Wind Scout Car", "Wheeled", 7 ,7000 ),
                new Tank("Packrat", "Wheeled", 20, 20000),
            };

            foreach (var m in tank)
            {
                Console.WriteLine("{0,-20} {1,-20}  {2,4} t {3,6} cB ", m.Bezeichnung, m.Antrieb, m.Tonne, m.Preis);
            }
            Console.WriteLine("\n----- Tank END -----\n");

            var json = serializer(mech);
            using (var sw = new StreamWriter(new FileStream(@"C:\Users\HP\Desktop\OOM\Teil 2\oom\tasks\Task4\mech.json", FileMode.Create)))
            {
                sw.Write(json);
            }
            var fs = new FileStream(@"C:\Users\HP\Desktop\OOM\Teil 2\oom\tasks\Task4\mech.json", FileMode.Open);
            var sr = new StreamReader(fs);

            string filetext = sr.ReadToEnd();

            var objectarray = deserializer(filetext);

            sr.Close();
            fs.Close();

            Console.WriteLine(filetext);
        }


        public static string serializer(Mech[] x)
        {
            return JsonConvert.SerializeObject(x, Formatting.Indented);
        }

        public static Mech[] deserializer(string json)
        {
            return JsonConvert.DeserializeObject<Mech[]>(json);
        }

    }
}
