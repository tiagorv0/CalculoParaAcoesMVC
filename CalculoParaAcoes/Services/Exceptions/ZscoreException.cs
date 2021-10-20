using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculoParaAcoes.Services.Exceptions
{
    public class ZscoreException : ApplicationException
    {
        public ZscoreException(string message) : base(message)
        {

        }
    }
}
