using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1A.Esercitazione.Chain
{
    class OpManagerHandler : AbstractHandler
    {
        public override string Handle(int request)
        {
            if(request <= 1000 && request > 401)
            {
                return $"approvato!non ti do di più però eh";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
