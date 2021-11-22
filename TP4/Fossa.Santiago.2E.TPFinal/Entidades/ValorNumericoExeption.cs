using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ValorNumericoExeption : Exception
    {
        public ValorNumericoExeption(string mensaje)
            :base(mensaje)
        {
            
        }

    }
}
