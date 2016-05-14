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
            Console.WriteLine();
            Console.WriteLine("----- IFahrzeuge ANFANG -----");
            Console.WriteLine();

            foreach (var m in ifahrzeuge)
            {
                Console.WriteLine("{0,-20} {1,4} t {2,6} cB ", m.Bezeichnung, m.Tonne, m.Preis);
            }

            Console.WriteLine();
            Console.WriteLine("----- IFahrzeuge ENDE -----");
            Console.WriteLine("----- Mech ANFANG -----");
            Console.WriteLine();

            var mech = new[]
            {
                new Mech("Panther", "Leicht",35, 35000),
                new Mech("Steppenwolf", "Mittel",45,45000),
                new Mech("Marauder", "Schwer",75,75000),
                new Mech("Atlas", "Überschwer",100,100000),
            };
            foreach (var m in mech)
            {
                Console.WriteLine("{0,-20} {1,-20}  {2,4} t {3,6} cB ", m.Bezeichnung,m.Klasse,m.Tonne,m.Preis);
            }
                                              
            Console.WriteLine();
            Console.WriteLine("----- Neue Preise Mech-----");
            Console.WriteLine();
            
            foreach (var m in mech)

            {
               Console.WriteLine("{0,-20} {1,-20}  {2,4} t {3,6} cB ", m.Bezeichnung, m.Klasse, m.Tonne, m.Preisupdate());
            }

            Console.WriteLine();
            Console.WriteLine("----- Mech ENDE -----");
            Console.WriteLine("----- Tank ANFANG -----");
            Console.WriteLine();

            var tank = new []
            {
                new Tank("Swift Wind Scout Car", "Wheeled", 7 ,7000 ),
                new Tank("Packrat", "Wheeled", 20, 20000),

            };

            foreach (var m in tank)

            {
                Console.WriteLine("{0,-20} {1,-20}  {2,4} t {3,6} cB ", m.Bezeichnung, m.Antrieb, m.Tonne, m.Preis);
            }
            Console.WriteLine();
            Console.WriteLine("----- Tank END -----");
            Console.WriteLine();
        }
    }
}
