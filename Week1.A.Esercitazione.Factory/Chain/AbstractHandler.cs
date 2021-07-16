using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1A.Esercitazione.Chain
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public virtual string Handle(int request)
        {
            if(this._nextHandler != null)
            {
                return this._nextHandler.Handle(request);  //se l'handler riceve la request giusta lo gestisce,se no ritorna null
            }else
            {
                return null;
            }
        }

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;   //se no lo passa al next handler
            return handler;
            
        }
    }
}
