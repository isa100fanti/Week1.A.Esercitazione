using System;
using System.Collections.Generic;
using Week1A.Esercitazione.Chain;
using Week1A.Esercitazione.Categorie;
using Week1.A.Esercitazione.Factory;

namespace Week1.A.Esercitazione
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FACTORY
            CategoriaFactory cat = new CategoriaFactory();
            Console.WriteLine("inserisci la categoria per cui vorresti avere un rimborso");
            string category = Console.ReadLine();
            ICategoria ic = cat.GetCategoria(category);
            
            Console.WriteLine("inserisci la tua spesa tot");
            double spesa = Convert.ToDouble(Console.ReadLine());

            ic.Spesa = spesa;
            Console.WriteLine(ic.Rimborso());
            #endregion

            #region ChAIN
            //Console.WriteLine("di che budget hai bisogno?");
            //int budget = Convert.ToInt32(Console.ReadLine());
            var manH = new ManagerHandler();
            var manOpH = new OpManagerHandler();
            var ceoH = new CeoHandler();

            manH.SetNext(manOpH).SetNext(ceoH);

            List<int> richieste = new List<int>() { 300, 2500, 603, 25100, 230, 1550 };
            foreach (var r in richieste)
            {
                var result = manH.Handle(r);

                if (r != null)
                {
                    Console.WriteLine(result + $"\ntieni {r} euro! \n-------");
                }
                else
                {
                    Console.WriteLine("non siamo la banca d'italia!");
                }
            }
            #endregion

            #region SalvaSpesa
            Spesa s = new Spesa()
            {
                DataSpesa = new DateTime(2021, 07, 10),
                Categoria = "Vitto",
                Descrizione = "pranzo e cena",
                Importo = 100,
                LvlApprov = 1

            };
            s.SavetoFileRimborsato("rimborsato.txt");
            s.SavetoFileNONRimborsato("NOnrimborsato.txt");
            #endregion
        }
    }
}
