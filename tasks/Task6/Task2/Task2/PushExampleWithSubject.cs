using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    public static class PushExampleWithSubject
    {
        public static void Run(IFahrzeuge[] ifahrzeuge)
        {
            var source = new Subject<IFahrzeuge>();

            source
                //.Sample(TimeSpan.FromSeconds(1.0))
                .Where(x=> x is Mech)
                .Subscribe(m => Console.WriteLine("Mech: {0,-20} {1,-2}t {2,6} cB ", m.Bezeichnung, m.Tonne, m.Preis));
                ;
            source
               //.Sample(TimeSpan.FromSeconds(1.0))
               .Where(x => x is Tank)
               .Subscribe(m => Console.WriteLine("Tank: {0,-20} {1,-2}t {2,6} cB ", m.Bezeichnung, m.Tonne, m.Preis));
            ;
            var t = new Thread(() =>
            {

            Random rnd = new Random(DateTime.Now.Millisecond);
            
                while (true)
                {
                    var rndnum = rnd.Next(ifahrzeuge.Length);
                    Thread.Sleep(1000);
                    source.OnNext (ifahrzeuge[rndnum]); // anlage und in queue              
                }
            });
            t.Start();
        }



    }
}
