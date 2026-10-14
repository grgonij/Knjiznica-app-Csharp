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
    public partial class DodajKnjigu : Form
    {

        public Knjiga? NovaKnjiga { get; private set; }
        public DodajKnjigu()
        {
            InitializeComponent();
            rbFizicka.CheckedChanged += (s, e) => tbFormat.Enabled = !rbFizicka.Checked;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNaslov.Text) || string.IsNullOrWhiteSpace(tbAutor.Text))
            {
                MessageBox.Show("Naslov i autor su obavezni.", "Napomena");
                return;
            }

            var isbn = new ISBNInfo(tbIsbn.Text, "Nepoznat izdavač");

            NovaKnjiga = rbElektronicka.Checked
                ? new EKnjiga(tbNaslov.Text, tbAutor.Text, isbn, tbFormat.Text)
                : new Knjiga(tbNaslov.Text, tbAutor.Text, isbn);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
