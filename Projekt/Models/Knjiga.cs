using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt.Models
{
    public class Knjiga
    {
        public string Naslov { get; set; }
        public string Autor { get; set; }
        public bool Procitano { get; set; }
        public bool Dostupna { get; private set; } = true;
        public ISBNInfo Isbn { get; set; }

        public Knjiga(string naslov, string autor, ISBNInfo isbn)
        {
            Naslov = naslov;
            Autor = autor;
            Isbn = isbn;
        }

        public void Posudi()
        {
            if (!Dostupna)
            {
                throw new Exceptions.KnjigaNijeDostupnaException($"Knjiga '{Naslov}' trenutno nije dostupna :(");
            }
            Dostupna = false;
            
        }

        public void Vrati()
        {
            Dostupna = true;
        }

        public virtual string PrikaziInfo()
        {
            string status = Dostupna ? "dostupna" : "posudena";
            string procitano = Procitano ? "da" : "ne";
            return $"{Naslov} - {Autor} | ISBN: {Isbn} | Dostupna: {status} | Pročitano: {procitano}";
        }
    }
}
