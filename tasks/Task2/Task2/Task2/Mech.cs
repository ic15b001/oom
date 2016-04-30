using System;


namespace Task2
{
    public class Mech
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
        public decimal Preis { get; }
      
        public decimal Preisupdate()
        {
            return Preis * 2;
        }
       
    }
}
