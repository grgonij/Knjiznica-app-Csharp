using Projekt.Services;
using Projekt.Models; 

namespace Projekt
{
    public partial class Form1 : Form
    {
        private List<Knjiga> prikazaneKnjige = new List<Knjiga>();

        private readonly KnjigaRepozitorij repozitorij;

        public Form1()
        {
            repozitorij = new KnjigaRepozitorij(
                Path.Combine(AppContext.BaseDirectory, "knjige.json"));
            InitializeComponent();
            InicijalizirajKomponente();
            _ = UcitajIPrikaziAsync();
        }

        private void InicijalizirajKomponente()
        {
            var meni = new MenuStrip();
            var datotekaMeni = new ToolStripMenuItem("Datoteka");
            var izlazStavka = new ToolStripMenuItem("Izlaz", null, (s, e) => Close());
            datotekaMeni.DropDownItems.Add(izlazStavka);

            var pomocMeni = new ToolStripMenuItem("Pomoć");
            var oAplikacijiStavka = new ToolStripMenuItem("O aplikaciji", null,
                (s, e) => MessageBox.Show("Evidencija knjižnice v1.0", "O aplikaciji"));
            pomocMeni.DropDownItems.Add(oAplikacijiStavka);

            meni.Items.Add(datotekaMeni);
            meni.Items.Add(pomocMeni);
            MainMenuStrip = meni;
            Controls.Add(meni);

            checkPrikazi.CheckedChanged += (s, e) => OsvjeziPrikaz();
        }

        private async Task UcitajIPrikaziAsync()
        {
            await repozitorij.UcitajAsync();
            OsvjeziPrikaz();
        }

        private void OsvjeziPrikaz()
        {
            listaKnjiga.Items.Clear();

            prikazaneKnjige = checkPrikazi.Checked
                ? repozitorij.Knjige.Where(k => k.Dostupna).ToList()
                : repozitorij.Knjige;

            foreach (var knjiga in prikazaneKnjige)
                listaKnjiga.Items.Add(knjiga.PrikaziInfo());
        }

        private void gumbDodaj_Click(object sender, EventArgs e)
        {
            using var forma = new DodajKnjigu();
            if (forma.ShowDialog(this) == DialogResult.OK && forma.NovaKnjiga != null)
            {
                repozitorij.Dodaj(forma.NovaKnjiga);
                OsvjeziPrikaz();
                _ = repozitorij.SpremiAsync();
            }
        }

        private void gumbPosudi_Click(object sender, EventArgs e)
        {
            var knjiga = OdabranaKnjiga();
            if (knjiga == null) return;

            try
            {
                knjiga.Posudi();
                OsvjeziPrikaz();
                _ = repozitorij.SpremiAsync();
            }
            catch (Exceptions.KnjigaNijeDostupnaException ex)
            {
                MessageBox.Show(ex.Message, "Greška");
            }
        }

        private void gumbVrati_Click(object sender, EventArgs e)
        {
            var knjiga = OdabranaKnjiga();
            if (knjiga == null) return;

            knjiga.Vrati();
            OsvjeziPrikaz();
            _ = repozitorij.SpremiAsync();
        }

        private Knjiga? OdabranaKnjiga()
        {
            int indeks = listaKnjiga.SelectedIndex;
            if (indeks < 0 || indeks >= repozitorij.Knjige.Count)
            {
                MessageBox.Show("Odaberi knjigu s popisa.", "Napomena");
                return null;
            }
            return repozitorij.Knjige[indeks];
        }

        private void ListaKnjiga_DoubleClick(object sender, MouseEventArgs e)
        {
            var knjiga = OdabranaKnjiga();
            if (knjiga == null) return;

            using var forma = new DetaljiKnjige(knjiga);
            forma.ShowDialog(this);
        }

        private void btnProcitano_Click(object sender, EventArgs e)
        {
            var knjiga = OdabranaKnjiga();
            if (knjiga == null) return;

            knjiga.Procitano = true;
            OsvjeziPrikaz();
            _ = repozitorij.SpremiAsync();
        }
    }
}
