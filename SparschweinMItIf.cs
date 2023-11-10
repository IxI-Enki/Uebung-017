/*------------------------------------------------------------------------------
 *                      HTBLA-Leonding / Class: 3ACIF                           
 *------------------------------------------------------------------------------
 *                      Jan Ritt                                                
 *------------------------------------------------------------------------------
 *  Description:  Das Programm ließt über die Konsole die Anzahlen einiger      
 *                Geldstücke (int) ein und gibt das gesamte Ersparrte (double)  
 *                aus.                                                          
 *------------------------------------------------------------------------------
*/
using System;
using System.Text;                           //  um "€" im Terminal zu verwenden
namespace SparschweinMitIf
{
    class Program
    {
        public static void Main()
        {
            int twentyCents, fiftyCents, oneEuros, twoEuros, eurosOutput, centsOutput;
            double savings = 0;

            Console.OutputEncoding = Encoding.UTF8;    //  "€" im Terminal ausgeben

            // Eingabe (E)  --  (Überschrift/Header)
            Console.Clear();
            Console.Write("\n Sparschwein mit if\n");
            Console.Write("------------------\n");
            // Eingabe (E)  --  Rechner
            Console.Write($"Wie viele 20¢ - Stücke haben Sie gesparrt:  ");
            twentyCents = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Wie viele 50¢ - Stücke haben Sie gesparrt:  ");
            fiftyCents = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Wie viele 1 € - Stücke haben Sie gesparrt:  ");
            oneEuros = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Wie viele 2 € - Stücke haben Sie gesparrt:  ");
            twoEuros = Convert.ToInt32(Console.ReadLine());
            Console.Write("------------------------------------------\n");

            // Verarbeitung (V)
            savings = oneEuros + (twoEuros * 2) + (fiftyCents * 0.5) + (twentyCents * 0.2);
            eurosOutput = (int)savings;                         // Extrahiere den Euro-Betrag
            centsOutput = (int)((savings - eurosOutput) * 100); // Extrahiere die Cent-Beträge
            // Ausgabe (A)  -- mit if
            if (eurosOutput == 0)
            {
                Console.Write($"\nSie haben {centsOutput}¢ angesparrt.\n");
            }
            else if (centsOutput == 0)
            {
                Console.Write($"\nSie haben {eurosOutput}€ angesparrt.\n");
            }
            else
            {
                Console.Write($"\nSie haben {eurosOutput}€ und {centsOutput}¢ angesparrt.\n");
            }

            // Ausgabe (A)  --  Ende
            Console.Write("\nEnter zum beenden drücken ...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
