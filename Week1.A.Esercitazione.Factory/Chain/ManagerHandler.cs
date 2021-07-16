using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1A.Esercitazione.Chain
{
    class ManagerHandler : AbstractHandler
    {
        public override string Handle(int request)
        {
            if(request <= 400)
            {
                return $"approvato!(meno male che sei economico)";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
