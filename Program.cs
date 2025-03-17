using System;
using ExcelDataReader;
using System.IO;
using System.Data;


namespace Personaliesierte_Daten_Auslesen
{
  class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Geben Sie die Vorname ein:  ");
            string name = Console.ReadLine();

            Console.Write(" Geben Sie die Nachname ein:  ");
            string nachname = Console.ReadLine();

            Console.Write(" Wie Alt?:  ");
            string alter = Console.ReadLine();

            string dateiPfad ="C:/Users/A.Graur/Documents/BKU/SWD/PersonenDaten.txt";
            Console.WriteLine("\n Daten wurden gespaichert");

            try
            {
                using (StreamWriter writer = new StreamWriter(dateiPfad))
                {
                    writer.WriteLine($"\n Vorname: {name}");
                    writer.WriteLine($" Nachname: {nachname}");
                    writer.WriteLine($" Alter: {alter}");

                }
               

                //Daten uas DAtei auslesen

                using (StreamReader reader = new StreamReader(dateiPfad))
                {
                    string inhalt = reader.ReadToEnd();


                    Console.WriteLine(inhalt);  //Datei ausgeben
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Fehler:  {ex.Message}");
            }
            


   
        }
    }
}
