using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt.Models
{
    public struct ISBNInfo
    {
        public string Isbn { get; set; }
        public string Izdavac { get; set; }

        public ISBNInfo(string isbn, string izdavac)
        {
            Isbn = isbn;
            Izdavac = izdavac;
        }

        public override string ToString()
        {
            return $"{Isbn} ({Izdavac})";
        }
    }
}
