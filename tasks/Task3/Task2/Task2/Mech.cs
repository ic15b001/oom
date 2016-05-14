using System;


namespace Task2
{


    public interface IFahrzeuge
    {
        string Bezeichnung { get; }
        decimal Tonne { get; }
        decimal Preis { get; }

    }


    public class Mech : IFahrzeuge
    {
        private decimal m_preis;
        public Mech(string bezeichnung, string klasse, decimal tonne, decimal preis)
        {
            if (string.IsNullOrWhiteSpace(bezeichnung)) throw new ArgumentException("Mech muss einen Namen besitzen!", nameof(bezeichnung));
            if (string.IsNullOrWhiteSpace(klasse)) throw new ArgumentException("Mech muss einer Klasse zugeordnet sein!", nameof(klasse));
            if (tonne < 0) throw new ArgumentException("Mech muss ein Gewicht haben!", nameof(tonne));
            if (preis < 0) throw new ArgumentException("Mech muss einen Preis haben!", nameof(preis));

            Bezeichnung = bezeichnung;
            Klasse = klasse;
            Tonne = tonne;
            Preis = preis;
            m_preis = preis;
          
        }
         
        public string Bezeichnung { get; }
        public string Klasse { get; }
        public decimal Tonne { get; }
        public decimal Preis { get; } //public decimal Preis { get { return m_preis; } set { m_preis = value; } }

        public decimal Preisupdate()
        {
            return Preis * 2;
        }
                      
    }

    public class Tank : IFahrzeuge
    {

        private decimal t_preis;

        public Tank(string bezeichnung, string antrieb, decimal tonne, decimal preis)
        {
            if (string.IsNullOrWhiteSpace(bezeichnung)) throw new ArgumentException("Tank muss einen Namen besitzen!", nameof(bezeichnung));
            if (string.IsNullOrWhiteSpace(antrieb)) throw new ArgumentException("Tank muss einer Antrieb zugeordnet sein!", nameof(antrieb));
            if (tonne < 0) throw new ArgumentException("Mech muss ein Gewicht haben!", nameof(tonne));
            if (preis < 0) throw new ArgumentException("Tank muss einen Preis haben!", nameof(preis));

            Bezeichnung = bezeichnung;
            Antrieb = antrieb;
            Tonne = tonne;
            Preis = preis;
            t_preis = preis;

        }
        
        public string Bezeichnung { get; }
        public string Antrieb { get; }
        public decimal Tonne { get; }
        public decimal Preis { get; } 

       
    }
}
