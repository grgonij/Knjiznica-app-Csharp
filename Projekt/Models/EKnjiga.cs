using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt.Models
{
    public class EKnjiga : Knjiga
    {
        public string FormatDatoteke { get; set; }

        public EKnjiga(string naslov, string autor, ISBNInfo isbn, string formatDatoteke) : base(naslov, autor, isbn)
        {
            FormatDatoteke = formatDatoteke;
        }

        public override string PrikaziInfo()
        {
            return base.PrikaziInfo() + $" | Format: {FormatDatoteke}";
        }

        
    }
}
