using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.A.Esercitazione.Factory
{
    public interface ICategoria
    {
        public string Tipo { get; set; }
        public double CalcolaRimborso();
        public double Spesa { get; set; }
        public string Rimborso();
    }
}
