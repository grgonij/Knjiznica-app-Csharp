namespace Projekt
{
    partial class DodajKnjigu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbNaslov = new TextBox();
            tbAutor = new TextBox();
            tbIsbn = new TextBox();
            tbFormat = new TextBox();
            lblNaslov = new Label();
            lblAutor = new Label();
            lblIsbn = new Label();
            lblFormat = new Label();
            rbFizicka = new RadioButton();
            rbElektronicka = new RadioButton();
            btnSpremi = new Button();
            SuspendLayout();
            // 
            // tbNaslov
            // 
            tbNaslov.Location = new Point(275, 40);
            tbNaslov.Name = "tbNaslov";
            tbNaslov.Size = new Size(229, 23);
            tbNaslov.TabIndex = 0;
            // 
            // tbAutor
            // 
            tbAutor.Location = new Point(275, 126);
            tbAutor.Name = "tbAutor";
            tbAutor.Size = new Size(229, 23);
            tbAutor.TabIndex = 1;
            // 
            // tbIsbn
            // 
            tbIsbn.Location = new Point(275, 211);
            tbIsbn.Name = "tbIsbn";
            tbIsbn.Size = new Size(229, 23);
            tbIsbn.TabIndex = 2;
            // 
            // tbFormat
            // 
            tbFormat.Enabled = false;
            tbFormat.Location = new Point(275, 356);
            tbFormat.Name = "tbFormat";
            tbFormat.Size = new Size(229, 23);
            tbFormat.TabIndex = 3;
            // 
            // lblNaslov
            // 
            lblNaslov.AutoSize = true;
            lblNaslov.Location = new Point(275, 22);
            lblNaslov.Name = "lblNaslov";
            lblNaslov.Size = new Size(43, 15);
            lblNaslov.TabIndex = 4;
            lblNaslov.Text = "Naslov";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(275, 108);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(37, 15);
            lblAutor.TabIndex = 5;
            lblAutor.Text = "Autor";
            // 
            // lblIsbn
            // 
            lblIsbn.AutoSize = true;
            lblIsbn.Location = new Point(275, 193);
            lblIsbn.Name = "lblIsbn";
            lblIsbn.Size = new Size(29, 15);
            lblIsbn.TabIndex = 6;
            lblIsbn.Text = "Isbn";
            // 
            // lblFormat
            // 
            lblFormat.AutoSize = true;
            lblFormat.Location = new Point(275, 338);
            lblFormat.Name = "lblFormat";
            lblFormat.Size = new Size(91, 15);
            lblFormat.TabIndex = 7;
            lblFormat.Text = "Format e-knjige";
            // 
            // rbFizicka
            // 
            rbFizicka.AutoSize = true;
            rbFizicka.Checked = true;
            rbFizicka.Location = new Point(275, 274);
            rbFizicka.Name = "rbFizicka";
            rbFizicka.Size = new Size(60, 19);
            rbFizicka.TabIndex = 8;
            rbFizicka.TabStop = true;
            rbFizicka.Text = "Fizička";
            rbFizicka.UseVisualStyleBackColor = true;
            // 
            // rbElektronicka
            // 
            rbElektronicka.AutoSize = true;
            rbElektronicka.Location = new Point(389, 274);
            rbElektronicka.Name = "rbElektronicka";
            rbElektronicka.Size = new Size(89, 19);
            rbElektronicka.TabIndex = 9;
            rbElektronicka.Text = "Elektronička";
            rbElektronicka.UseVisualStyleBackColor = true;
            // 
            // btnSpremi
            // 
            btnSpremi.Location = new Point(353, 396);
            btnSpremi.Name = "btnSpremi";
            btnSpremi.Size = new Size(75, 23);
            btnSpremi.TabIndex = 10;
            btnSpremi.Text = "Spremi";
            btnSpremi.UseVisualStyleBackColor = true;
            btnSpremi.Click += btnSpremi_Click;
            // 
            // DodajKnjigu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSpremi);
            Controls.Add(rbElektronicka);
            Controls.Add(rbFizicka);
            Controls.Add(lblFormat);
            Controls.Add(lblIsbn);
            Controls.Add(lblAutor);
            Controls.Add(lblNaslov);
            Controls.Add(tbFormat);
            Controls.Add(tbIsbn);
            Controls.Add(tbAutor);
            Controls.Add(tbNaslov);
            Name = "DodajKnjigu";
            Text = "DodajKnjigu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNaslov;
        private TextBox tbAutor;
        private TextBox tbIsbn;
        private TextBox tbFormat;
        private Label lblNaslov;
        private Label lblAutor;
        private Label lblIsbn;
        private Label lblFormat;
        private RadioButton rbFizicka;
        private RadioButton rbElektronicka;
        private Button btnSpremi;
    }
}