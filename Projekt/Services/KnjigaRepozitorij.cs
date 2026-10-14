using Projekt.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Projekt.Services
{
    public class KnjigaRepozitorij
    {
        public List<Knjiga> Knjige { get; private set; } = new List<Knjiga>();

        private readonly String putanjaDatoteke;

        public KnjigaRepozitorij(string putanjaDatoteke)
        {
            this.putanjaDatoteke = putanjaDatoteke;
        }

        public void Dodaj(Knjiga knjiga)
        {
            Knjige.Add(knjiga);
        }

        public void Ukloni(Knjiga knjiga)
        {
            Knjige.Remove(knjiga);
        }

        public async Task SpremiAsync()
        {
            var opcije = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(Knjige, opcije);
            await File.WriteAllTextAsync(putanjaDatoteke, json);
        }

        public async Task UcitajAsync()
        {
            if (!File.Exists(putanjaDatoteke))
                return;

            string json = await File.ReadAllTextAsync(putanjaDatoteke);
            var ucitane = JsonSerializer.Deserialize<List<Knjiga>>(json);

            if (ucitane != null)
                Knjige = ucitane;
        }
    }
}
