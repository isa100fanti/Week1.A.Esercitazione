using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.A.Esercitazione.Factory.Categorie;

namespace Week1.A.Esercitazione.Factory
{
    public class CategoriaFactory 
    {
        public ICategoria GetCategoria(string tipo)
        {
            ICategoria c = null;
            switch(tipo)
            {
                case "Viaggio":
                    c = new Viaggio();
                    break;
                case "Alloggio":
                    c = new Alloggio();
                    break;
                case "Vitto":
                    c = new Vitto();
                    break;
                case "Altro":
                    c = new Altro();
                    break;
            }

            return c;
        }
    }
}
