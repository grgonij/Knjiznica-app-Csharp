namespace Projekt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listaKnjiga = new ListBox();
            gumbDodaj = new Button();
            gumbPosudi = new Button();
            gumbVrati = new Button();
            checkPrikazi = new CheckBox();
            btnProcitano = new Button();
            SuspendLayout();
            // 
            // listaKnjiga
            // 
            listaKnjiga.FormattingEnabled = true;
            listaKnjiga.HorizontalScrollbar = true;
            listaKnjiga.Location = new Point(159, 60);
            listaKnjiga.Name = "listaKnjiga";
            listaKnjiga.ScrollAlwaysVisible = true;
            listaKnjiga.Size = new Size(444, 169);
            listaKnjiga.TabIndex = 0;
            listaKnjiga.MouseDoubleClick += ListaKnjiga_DoubleClick;
            // 
            // gumbDodaj
            // 
            gumbDodaj.Location = new Point(159, 280);
            gumbDodaj.Name = "gumbDodaj";
            gumbDodaj.Size = new Size(75, 23);
            gumbDodaj.TabIndex = 1;
            gumbDodaj.Text = "Dodaj";
            gumbDodaj.UseVisualStyleBackColor = true;
            gumbDodaj.Click += gumbDodaj_Click;
            // 
            // gumbPosudi
            // 
            gumbPosudi.Location = new Point(346, 280);
            gumbPosudi.Name = "gumbPosudi";
            gumbPosudi.Size = new Size(75, 23);
            gumbPosudi.TabIndex = 2;
            gumbPosudi.Text = "Posudi";
            gumbPosudi.UseVisualStyleBackColor = true;
            gumbPosudi.Click += gumbPosudi_Click;
            // 
            // gumbVrati
            // 
            gumbVrati.Location = new Point(528, 280);
            gumbVrati.Name = "gumbVrati";
            gumbVrati.Size = new Size(75, 23);
            gumbVrati.TabIndex = 3;
            gumbVrati.Text = "Vrati";
            gumbVrati.UseVisualStyleBackColor = true;
            gumbVrati.Click += gumbVrati_Click;
            // 
            // checkPrikazi
            // 
            checkPrikazi.AutoSize = true;
            checkPrikazi.Location = new Point(312, 235);
            checkPrikazi.Name = "checkPrikazi";
            checkPrikazi.Size = new Size(145, 19);
            checkPrikazi.TabIndex = 4;
            checkPrikazi.Text = "Prikaži samo dostupne";
            checkPrikazi.UseVisualStyleBackColor = true;
            // 
            // btnProcitano
            // 
            btnProcitano.Location = new Point(295, 343);
            btnProcitano.Name = "btnProcitano";
            btnProcitano.Size = new Size(177, 23);
            btnProcitano.TabIndex = 5;
            btnProcitano.Text = "Označi kao pročitano";
            btnProcitano.UseVisualStyleBackColor = true;
            btnProcitano.Click += btnProcitano_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProcitano);
            Controls.Add(checkPrikazi);
            Controls.Add(gumbVrati);
            Controls.Add(gumbPosudi);
            Controls.Add(gumbDodaj);
            Controls.Add(listaKnjiga);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listaKnjiga;
        private Button gumbDodaj;
        private Button gumbPosudi;
        private Button gumbVrati;
        private CheckBox checkPrikazi;
        private Button btnProcitano;
    }
}
