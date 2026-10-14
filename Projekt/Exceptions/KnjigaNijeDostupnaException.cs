using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt.Exceptions
{
    public class KnjigaNijeDostupnaException : Exception
    {
        public KnjigaNijeDostupnaException(string poruka) : base(poruka) { }
        
    }
}
