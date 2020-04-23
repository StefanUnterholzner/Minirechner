using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02untste_Minirechner
{
    class Program
    {
        static void Main(string[] args)
        {
            int Zahl1 = 0;
            int Zahl2 = 0;
            String Operant = "";
            Titelerstellen("Minirechner","", 0);
            Console.Write("Bitte eine Zahl eingeben: ");
            Zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitte einen Operant (+/-/*/:) eingeben: ");
            Operant =Console.ReadLine();
            Console.Write("Bitte eine Zahl eingeben: ");
            Zahl2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Das Ergebnis ist: ");
            Console.WriteLine(Convert.ToString(rechnen(Zahl1, Operant, Zahl2)));
            Console.ReadKey();
        }
        /// <summary>
        /// Erstellt an einer belibigen Stelle eine Überschrift
        /// </summary>
        /// <param name="Titel">Titel</param>
        /// <param name="Untertitel">Untertittel, wenn "" wird der Untertitel weggelassen</param>
        /// <param name="PositionTop">Possition des Beginn das Titels(Zeilen von Oben)</param>
        static void Titelerstellen(String Titel, String Untertitel, int PositionTop)
        {
            Console.SetCursorPosition(0, PositionTop);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("-");
            }
            Console.Write("-");
            Console.SetCursorPosition((Console.WindowWidth-Titel.Length)/2,PositionTop+1);
            Console.Write(Titel);
            Console.SetCursorPosition(Console.WindowWidth-1, PositionTop + 1);
            Console.Write("-");
            if (Untertitel != "")
            {
                Console.Write("-");
                Console.SetCursorPosition((Console.WindowWidth - Untertitel.Length)/2, PositionTop + 2);
                Console.Write(Untertitel);
                Console.SetCursorPosition(Console.WindowWidth - 1, PositionTop + 2);
                Console.Write("-");
            }
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("-");
            }
            
        }
        static int rechnen(int Num1, string Op, int Num2)
        {
            int Ergebniss = 0;
            if (Op == "+")
                Ergebniss=Addieren(Num1, Num2);
            return Ergebniss;
        }
        static int Addieren(int Summand1, int Summand2)
        {
            return (Summand1 + Summand2);
        }
    }
}
