using System;


namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var mech = new[]
            {
                new Mech("Heuschrech", "Leicht",20,20000),
                new Mech("Panther", "Leicht",35, 35000),
                new Mech("Vindicator", "Mittel",45,45000),
                new Mech("Steppenwolf", "Mittel",45,45000),
                new Mech("Donnerkeil", "Schwer",65,65000),
                new Mech("Marauder", "Schwer",75,75000),
                new Mech("Victor", "Überschwer",80,80000),
                new Mech("Atlas", "Überschwer",100,100000),
            };
            foreach (var m in mech)
            {
                Console.WriteLine("{0,-20} {1,-20}  {2,4} t {3,6} cB ", m.Bezeichnung,m.Klasse,m.Tonne,m.Preis);
            }
            
            
                        
            Console.WriteLine();
            Console.WriteLine("----- Neue Preise -----");
            Console.WriteLine();


            foreach (var m in mech)

            {
               Console.WriteLine("{0,-20} {1,-20}  {2,4} t {3,6} cB ", m.Bezeichnung, m.Klasse, m.Tonne, m.Preisupdate());
            }


        }
    }
}
