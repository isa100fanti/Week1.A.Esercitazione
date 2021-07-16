using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1A.Esercitazione.Categorie
{
    public class Spesa
    {
        public DateTime DataSpesa { get; set; }
        public string Categoria { get; set; }
        public string Descrizione { get; set; }
        //public string Approvata { get; set; }
        public int LvlApprov { get;  set; }
        public double Importo { get; set; }
        public string Path { get; } = @"C:\Users\isabella.centofanti\Desktop\EsercitazioneW1Academy";

        public void LoadFile(string percorso)
        {
            using (StreamReader reader = File.OpenText(Path + percorso))
            {
                string dettaglio = reader.ReadLine();
                string[] values = dettaglio.Split(";");

                DataSpesa = Convert.ToDateTime(values[0]);
                Categoria = values[1];
                Descrizione = values[2];
                Importo = Convert.ToDouble(values[3]);
                Console.WriteLine("file letto");
            }

        }
        
        public void SavetoFileRimborsato(string percorso)
        {
            try
            {
                using (StreamWriter writer = File.CreateText(Path + percorso))
                {
                    writer.Write($"{DataSpesa.ToShortDateString()};{Descrizione};Approvata;{LvlApprov};{ImportoRimborsato}");
                    Console.WriteLine("file creato!");
                }
            }catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
            //Data;Categoria;Descrizione;APPROVATA;LvlApprov;ImportoRimborsato
        }

        public void SavetoFileNONRimborsato(string percorso)
        {
            try
            {
                using (StreamWriter writer = File.CreateText(Path + percorso))
                {
                    writer.Write($"{DataSpesa.ToShortDateString()};{Descrizione};RESPINTA");
                    Console.WriteLine("file creato!");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            //Data;Categoria;Descrizione;RESPINTA
        }

    }
}
