using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffeemaschine
{
    internal class Kaffeemaschine
    {
        int wasserstand;
        int bohnenMenge;
        static int maxWasserstand = 2500;  //Menge in ml
        static int maxBohnenmenge = 500;   //Menge in Gramm

        public Kaffeemaschine(int wasserstand, int bohnenMenge) 
        {
            this.wasserstand = wasserstand; 
            this.bohnenMenge = bohnenMenge;  
        }

        public int Wasserstand { get => wasserstand; set => wasserstand = value; }
        public int BohnenMenge { get => bohnenMenge; set => bohnenMenge = value; }
        public static int MaxWasserstand { get => maxWasserstand; }
        public static int MaxBohnenmenge { get => maxBohnenmenge; }


        public void WerteAnzeigen()
        {
            Console.WriteLine($"Aktuell sind noch {wasserstand} ml Wasser und {bohnenMenge} Gramm Kaffeebohnen im jeweiligen Tank.");
            Console.WriteLine($"\nEs können noch {maxWasserstand - wasserstand} ml Wasser und {maxBohnenmenge - bohnenMenge} Gramm Kaffeebohnen aufgefüllt werden.");
        }
        public void WasserNachfuellen()
        {
            wasserstand = maxWasserstand;
            Console.WriteLine("Wasser wurde aufgefüllt!");
        }
        public void BohnenNachfuellen()
        {
            bohnenMenge = maxBohnenmenge;
            Console.WriteLine("Bohnen wurden aufgefüllt!");
        }
        public void KaffeMachen()
        {
            int wasserVerbrauch = 200;
            int bohnenVerbrauch = 12;

            if (wasserstand >= wasserVerbrauch && bohnenMenge >= bohnenVerbrauch)
            {
                wasserstand -= wasserVerbrauch;
                bohnenMenge -= bohnenVerbrauch;
                Console.Clear();
                Console.WriteLine("\nIhr Kaffe wird zubereitet");
                Console.Write("\nXXX");
                Thread.Sleep(1000);
                Console.Write("XXX");
                Thread.Sleep(1000);
                Console.Write("XXX");
                Thread.Sleep(1000);
                Console.Write("XXX");
                Thread.Sleep(1000);
                Console.Write("XXX");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("\nBitte entnehmen sie ihren Kaffee");
                Console.ReadKey();
            }
            else if (wasserstand < wasserVerbrauch)
            {
                Console.Clear();
                Console.WriteLine("\nWasserstand zu gering. \nBitte Nachfüllen!");
                Thread.Sleep(3000);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nZu wenig Bohnen. \n Bitte Nachfüllen!");
                Thread.Sleep(3000);
            }
        }
    }
}
