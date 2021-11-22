using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DatoIncorrectoException : Exception
    {
        public DatoIncorrectoException(string mensaje)
            : base(mensaje)
        {

        }
    }
}
