using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace Task2
{
    public static class TasksExample
    {
        public static void Run(IFahrzeuge[] ifahrzeuge)
        {
            var rnd = new Random(DateTime.Now.Millisecond);

            var tasks = new List<Task<IFahrzeuge[]>>();

            foreach (var x in ifahrzeuge)
            {
                
                var task = begebnungerstellen(x, ifahrzeuge);

                tasks.Add(task);
            }

            //WriteLine("doing something else ...");

            var tasks2 = new List<Task>(); // keine return wert
            foreach (var task in tasks.ToArray()) //toarray kopiert in eine Liste -- keine Veränderung während Abarbeitung
            {
                tasks2.Add(
                    task.ContinueWith(t =>
                    {
                        var rndnum = rnd.Next(2);
                        WriteLine($"-------Der Sieger ist {t.Result[rndnum].Bezeichnung} ------- Spieler {rndnum} ");

                    }) // Tast anhängen t ist der alte
                );
            }

        }

        public static async Task randomwait()
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            await Task.Delay(TimeSpan.FromSeconds(5.0 + rnd.Next(10)));
        }

        public static Task<IFahrzeuge[]> begebnungerstellen(IFahrzeuge x, IFahrzeuge[] ifahrzeuge  )
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            return Task.Run(() =>
            {
                var rndnum = rnd.Next(ifahrzeuge.Length);
                WriteLine($"-- Begegnung: {x.Bezeichnung} SP 0 ---- VS ---- {ifahrzeuge[rndnum].Bezeichnung} SP 1 --");
                randomwait().Wait();
                return new[] { x, ifahrzeuge[rndnum] };
            });
        }

        
    }
}
