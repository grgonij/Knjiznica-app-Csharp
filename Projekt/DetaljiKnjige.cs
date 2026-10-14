using Projekt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projekt
{
    public partial class DetaljiKnjige : Form
    {
        public DetaljiKnjige(Knjiga knjiga)
        {
            InitializeComponent();
            string format = knjiga is EKnjiga eKnjiga ? eKnjiga.FormatDatoteke : "— (fizička knjiga)";
            string posudena = knjiga.Dostupna ? "Ne" : "Da";
            string procitano = knjiga.Procitano ? "Da" : "Ne";

            Controls.AddRange(NapraviRedak("Ime:", knjiga.Naslov, 15));
            Controls.AddRange(NapraviRedak("Autor:", knjiga.Autor, 50));
            Controls.AddRange(NapraviRedak("ISBN:", knjiga.Isbn.ToString(), 85));
            Controls.AddRange(NapraviRedak("Format:", format, 120));
            Controls.AddRange(NapraviRedak("Posuđena:", posudena, 155));
            Controls.AddRange(NapraviRedak("Pročitano:", procitano, 190));

            var gumbZatvori = new Button { Text = "Zatvori", Left = 220, Top = 225 };
            gumbZatvori.Click += (s, e) => Close();
            Controls.Add(gumbZatvori);
        }

        private static Control[] NapraviRedak(string naziv, string vrijednost, int top)
        {
            var lblNaziv = new Label { Text = naziv, Left = 10, Top = top, Width = 100, Font = new Font(Control.DefaultFont, FontStyle.Bold) };
            var lblVrijednost = new Label { Text = vrijednost, Left = 120, Top = top, Width = 200 };
            return new Control[] { lblNaziv, lblVrijednost };
        }
    }
}
