using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMUE_Verbesserung_Figuren
{
    abstract class Figur
    {
        public abstract int GetAnzahlDerEcken();
    }
    class Dreieck : Figur
    {
        public override int GetAnzahlDerEcken()
        {
            return 3;
        }
    }
    class Rechteck : Figur
    {
        public override int GetAnzahlDerEcken()
        {
            return 4;
        }
    }
    class Program
    {

        public static int summeEcken(List<Figur> figuren)
        {
            int anzahl = 0;
            foreach (Figur item in figuren)
            {
                anzahl += item.GetAnzahlDerEcken();
            }
            return anzahl;
        }
        static void Main(string[] args)
        {
            List<Figur> figuren = new List<Figur>();
            figuren.Add(new Dreieck());
            figuren.Add(new Rechteck());
            Console.WriteLine($"Summe der Ecken: {summeEcken(figuren)}");
            Console.ReadKey();
            //
        }
    }
}
