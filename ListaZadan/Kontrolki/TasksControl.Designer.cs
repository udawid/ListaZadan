
namespace ListaZadan.Kontrolki
{
    partial class TasksControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTytul = new System.Windows.Forms.Label();
            this.lblZalogowany = new System.Windows.Forms.Label();
            this.lblZalogowanyWartosc = new System.Windows.Forms.Label();
            this.btnWyloguj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.lvZadania = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIsReady = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblTytul
            // 
            this.lblTytul.AutoSize = true;
            this.lblTytul.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTytul.Location = new System.Drawing.Point(3, 2);
            this.lblTytul.Name = "lblTytul";
            this.lblTytul.Size = new System.Drawing.Size(142, 64);
            this.lblTytul.TabIndex = 2;
            this.lblTytul.Text = "TODO";
            // 
            // lblZalogowany
            // 
            this.lblZalogowany.AutoSize = true;
            this.lblZalogowany.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZalogowany.Location = new System.Drawing.Point(144, 22);
            this.lblZalogowany.Name = "lblZalogowany";
            this.lblZalogowany.Size = new System.Drawing.Size(157, 24);
            this.lblZalogowany.TabIndex = 3;
            this.lblZalogowany.Text = "Zalogowany jako:";
            // 
            // lblZalogowanyWartosc
            // 
            this.lblZalogowanyWartosc.AutoSize = true;
            this.lblZalogowanyWartosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZalogowanyWartosc.Location = new System.Drawing.Point(294, 22);
            this.lblZalogowanyWartosc.Name = "lblZalogowanyWartosc";
            this.lblZalogowanyWartosc.Size = new System.Drawing.Size(82, 24);
            this.lblZalogowanyWartosc.TabIndex = 4;
            this.lblZalogowanyWartosc.Text = "Anonim";
            // 
            // btnWyloguj
            // 
            this.btnWyloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWyloguj.Location = new System.Drawing.Point(415, 9);
            this.btnWyloguj.Name = "btnWyloguj";
            this.btnWyloguj.Size = new System.Drawing.Size(73, 51);
            this.btnWyloguj.TabIndex = 8;
            this.btnWyloguj.Text = "⮜";
            this.btnWyloguj.UseVisualStyleBackColor = true;
            this.btnWyloguj.Click += new System.EventHandler(this.btnWyloguj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.Location = new System.Drawing.Point(415, 66);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(73, 210);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "🞥";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdytuj.Location = new System.Drawing.Point(415, 282);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(73, 210);
            this.btnEdytuj.TabIndex = 10;
            this.btnEdytuj.Text = "✏";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsun.Location = new System.Drawing.Point(415, 498);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(73, 126);
            this.btnUsun.TabIndex = 11;
            this.btnUsun.Text = "🗑";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // lvZadania
            // 
            this.lvZadania.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colTitle,
            this.colIsReady});
            this.lvZadania.FullRowSelect = true;
            this.lvZadania.GridLines = true;
            this.lvZadania.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvZadania.HideSelection = false;
            this.lvZadania.Location = new System.Drawing.Point(14, 66);
            this.lvZadania.MultiSelect = false;
            this.lvZadania.Name = "lvZadania";
            this.lvZadania.ShowGroups = false;
            this.lvZadania.Size = new System.Drawing.Size(395, 558);
            this.lvZadania.TabIndex = 12;
            this.lvZadania.UseCompatibleStateImageBehavior = false;
            this.lvZadania.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "Id";
            this.colId.Width = 38;
            // 
            // colTitle
            // 
            this.colTitle.Text = "Tytuł";
            this.colTitle.Width = 286;
            // 
            // colIsReady
            // 
            this.colIsReady.Text = "Zrobione";
            // 
            // TasksControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvZadania);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnWyloguj);
            this.Controls.Add(this.lblZalogowanyWartosc);
            this.Controls.Add(this.lblZalogowany);
            this.Controls.Add(this.lblTytul);
            this.Name = "TasksControl";
            this.Size = new System.Drawing.Size(500, 640);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTytul;
        private System.Windows.Forms.Label lblZalogowany;
        private System.Windows.Forms.Label lblZalogowanyWartosc;
        private System.Windows.Forms.Button btnWyloguj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.ListView lvZadania;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colIsReady;
    }
}
