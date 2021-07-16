using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1A.Esercitazione.Chain
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler); //per settare l'handler successivo
        string Handle(int request); //mi faccio restituire una string(approvato) e la request è con i soldi
    }
}
