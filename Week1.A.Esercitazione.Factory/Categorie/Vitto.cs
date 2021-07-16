using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.A.Esercitazione.Factory.Categorie
{
    public class Vitto : ICategoria
    {
        public string Tipo { get; set; } = "Vitto";
        public double Spesa { get; set; }

        public double CalcolaRimborso()
        {
            return Spesa * 0.5;
        }
        public string Rimborso()
        {
            return $"hai diritto a un rimborso di {CalcolaRimborso()} euro";
        }
    }
}
