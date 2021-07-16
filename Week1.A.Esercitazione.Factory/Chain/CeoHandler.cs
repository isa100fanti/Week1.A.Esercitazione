using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1A.Esercitazione.Chain
{
    class CeoHandler : AbstractHandler
    {
        public override string Handle(int request)
        {
            if(request > 1001 && request < 25000)
            {
                return $"sei un po'caro,ma per un CEO questo ed altro!";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
