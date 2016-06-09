using System;


namespace Task2
{
    public interface IFahrzeuge
    {
        string Bezeichnung { get; }
        decimal Tonne { get; }
        decimal Preis { get; }
    }
}
